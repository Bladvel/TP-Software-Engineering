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
    public class MP_SolicitudDeCompra: Mapper<SolicitudDeCompra>
    {
        public MP_SolicitudDeCompra(Access access, MP_ItemIngrediente mpItemIngrediente ) : base(access)
        {
            this.mpItemIngrediente = mpItemIngrediente;
        }

        private MP_ItemIngrediente mpItemIngrediente;
        public override SolicitudDeCompra GetById(object id)
        {
            throw new NotImplementedException();
        }

        public override SolicitudDeCompra Transform(DataRow dr)
        {
            SolicitudDeCompra solicitud = new SolicitudDeCompra();
            solicitud.NroSolicitud = int.Parse(dr["NRO_SOLICITUD"].ToString());
            solicitud.Fecha = DateTime.Parse(dr["FECHA"].ToString());
            solicitud.Ingredientes = mpItemIngrediente.GetItemsBySolicitud(solicitud.NroSolicitud);
            solicitud.Comentarios = dr["COMENTARIOS"].ToString();
            solicitud.Estado = (EstadoSolicitudCompra)Enum.Parse(typeof(EstadoSolicitudCompra), dr["ESTADO"].ToString());
            return solicitud;
        }

        public override List<SolicitudDeCompra> GetAll()
        {
            List<SolicitudDeCompra> solicitudes = new List<SolicitudDeCompra>();
            access.Open();
            DataTable dt = access.Read("LISTAR_SOLICITUD_DE_COMPRA");
            access.Close();
            foreach (DataRow dr in dt.Rows)
            {
                solicitudes.Add(Transform(dr));
            }
            return solicitudes;
        }

        public List<BE.SolicitudDeCompra> GetByState(EstadoSolicitudCompra estado)
        {
            List<SolicitudDeCompra> solicitudes = new List<SolicitudDeCompra>();
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


        public override int Insert(SolicitudDeCompra entity)
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
                itemIngrediente.SolicitudDeCompra = entity;
                mpItemIngrediente.Insert(itemIngrediente);
            }



            return entity.NroSolicitud;


        }

        public override int Update(SolicitudDeCompra entity)
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

        public int UpdateItems(SolicitudDeCompra entity)
        {
            int resultado = mpItemIngrediente.DeleteBySolicitud(entity.NroSolicitud);
            int filasAfectadas = 0;
            if(resultado != -1)
            {
                foreach (var itemIngrediente in entity.Ingredientes)
                {
                    itemIngrediente.SolicitudDeCompra = entity;
                    filasAfectadas += mpItemIngrediente.Insert(itemIngrediente);
                }
            }

            return filasAfectadas;
        }


        public override int Delete(SolicitudDeCompra entity)
        {
            throw new NotImplementedException();
        }
    }
}
