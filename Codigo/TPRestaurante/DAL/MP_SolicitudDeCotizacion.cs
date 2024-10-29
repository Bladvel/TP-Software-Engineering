using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Interfaces;

namespace DAL
{
    public class MP_SolicitudDeCotizacion: Mapper<SolicitudDeCotizacion>
    {
        public MP_SolicitudDeCotizacion(Access access, MP_ItemIngrediente mpItemIngrediente ) : base(access)
        {
            this.mpItemIngrediente = mpItemIngrediente;
        }

        private MP_ItemIngrediente mpItemIngrediente;
        public override SolicitudDeCotizacion GetById(object id)
        {
            int nroSolicitud = int.Parse(id.ToString());
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nro", nroSolicitud)
            };

            access.Open();
            DataTable dt = access.Read("OBTENER_SOLICITUD_DE_COMPRA_POR_ID", parameters);
            access.Close();

            SolicitudDeCotizacion solicitud = Transform(dt.Rows[0]);
            return solicitud;




        }

        public override SolicitudDeCotizacion Transform(DataRow dr)
        {
            SolicitudDeCotizacion solicitud = new SolicitudDeCotizacion();
            solicitud.NroSolicitud = int.Parse(dr["NRO_SOLICITUD"].ToString());
            solicitud.Fecha = DateTime.Parse(dr["FECHA"].ToString());
            solicitud.Ingredientes = mpItemIngrediente.GetItemsBySolicitud(solicitud.NroSolicitud);
            solicitud.Comentarios = dr["COMENTARIOS"].ToString();
            solicitud.Estado = (EstadoSolicitudCotizacion)Enum.Parse(typeof(EstadoSolicitudCotizacion), dr["ESTADO"].ToString());
            return solicitud;
        }

        public override List<SolicitudDeCotizacion> GetAll()
        {
            List<SolicitudDeCotizacion> solicitudes = new List<SolicitudDeCotizacion>();
            access.Open();
            DataTable dt = access.Read("LISTAR_SOLICITUD_DE_COMPRA");
            access.Close();
            foreach (DataRow dr in dt.Rows)
            {
                solicitudes.Add(Transform(dr));
            }
            return solicitudes;
        }

        public List<BE.SolicitudDeCotizacion> GetByState(EstadoSolicitudCotizacion estado)
        {
            List<SolicitudDeCotizacion> solicitudes = new List<SolicitudDeCotizacion>();
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@estado", estado.ToString())
            };
            access.Open();
            DataTable dt = access.Read("LISTAR_SOLICITUD_DE_COMPRA_POR_ESTADO", parameters);
            access.Close();
            foreach (DataRow dr in dt.Rows)
            {
                solicitudes.Add(Transform(dr));
            }
            return solicitudes;
        }


        public override int Insert(SolicitudDeCotizacion entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@fecha", entity.Fecha),
                access.CreateParameter("@comentarios", entity.Comentarios),
                access.CreateParameter("@estado", entity.Estado.ToString())
            };

            access.Open();
            entity.NroSolicitud = access.WriteScalar("INSERTAR_SOLICITUD_DE_COMPRA", parameters);
            access.Close();

            foreach (var itemIngrediente in entity.Ingredientes)
            {
                itemIngrediente.SolicitudDeCotizacion = entity;
                mpItemIngrediente.Insert(itemIngrediente);
            }



            return entity.NroSolicitud;


        }

        public override int Update(SolicitudDeCotizacion entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nroSolicitud", entity.NroSolicitud),
                access.CreateParameter("@nuevoEstado", entity.Estado.ToString())
            };

            access.Open();
            int result = access.Write("MODIFICAR_SOLICITUD_DE_COMPRA", parameters);
            access.Close();
            return result;
        }

        public int UpdateItems(SolicitudDeCotizacion entity)
        {
            int resultado = mpItemIngrediente.DeleteBySolicitud(entity.NroSolicitud);
            int filasAfectadas = 0;
            if(resultado != -1)
            {
                foreach (var itemIngrediente in entity.Ingredientes)
                {
                    itemIngrediente.SolicitudDeCotizacion = entity;
                    filasAfectadas += mpItemIngrediente.Insert(itemIngrediente);
                }
            }

            return filasAfectadas;
        }


        public override int Delete(SolicitudDeCotizacion entity)
        {
            throw new NotImplementedException();
        }
    }
}
