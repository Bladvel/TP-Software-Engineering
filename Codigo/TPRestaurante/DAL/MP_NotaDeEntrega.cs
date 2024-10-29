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
    public class MP_NotaDeEntrega: Mapper<BE.NotaDeEntrega>
    {
        public MP_NotaDeEntrega(Access access, MP_OrdenDeCompra mpOrdenDeCompra) : base(access)
        {
            this.mpOrdenDeCompra = mpOrdenDeCompra;
        }

        private MP_OrdenDeCompra mpOrdenDeCompra;


        public override NotaDeEntrega GetById(object id)
        {
            throw new NotImplementedException();
        }

        public override NotaDeEntrega Transform(DataRow dr)
        {
            int nroNota = Convert.ToInt32(dr["NRO_NOTA"]);
            DateTime fecha = Convert.ToDateTime(dr["FECHA"]);
            OrdenDeCompra ordenDeCompra = mpOrdenDeCompra.GetById(Convert.ToInt32(dr["NRO_ORDEN"]));
            EstadoNotaDeEntrega estadoNota = (EstadoNotaDeEntrega)Enum.Parse(typeof(EstadoNotaDeEntrega), dr["ESTADO"].ToString());
            String observaciones = dr["OBSERVACIONES"].ToString();
            return new NotaDeEntrega(nroNota, fecha, ordenDeCompra, estadoNota, observaciones);
            
        }

        public override List<NotaDeEntrega> GetAll()
        {
            List<NotaDeEntrega> notas = new List<NotaDeEntrega>();

            access.Close();
            DataTable tabla = access.Read("LISTAR_NOTA_DE_ENTREGA");
            access.Close();
            foreach (DataRow dr in tabla.Rows)
                notas.Add(Transform(dr));

            return notas;

        }

        public override int Insert(NotaDeEntrega entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@fecha", entity.Fecha),
                access.CreateParameter("@nro_orden", entity.OrdenDeCompra.NroOrden),
                access.CreateParameter("@estado", entity.EstadoNota.ToString()),
                access.CreateParameter("@observaciones", entity.Observaciones)
            };

            access.Open();
            int id = access.WriteScalar("INSERTAR_NOTA_DE_ENTREGA", parameters);
            access.Close();
            return id;


        }

        public override int Update(NotaDeEntrega entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(NotaDeEntrega entity)
        {
            throw new NotImplementedException();
        }
    }
}
