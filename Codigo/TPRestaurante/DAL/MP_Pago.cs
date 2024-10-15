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
    public class MP_Pago: Mapper<BE.Pago>
    {
        public override Pago GetById(object id)
        {
            throw new NotImplementedException();
        }
        MP_Pedido mpPedido;
        MP_MetodoDePago mpMetodo;
        public override Pago Transform(DataRow dr)
        {
            Pedido pedido = mpPedido.GetById(dr["ID_PEDIDO"].ToString());
            MetodoDePago metodo = mpMetodo.GetById(dr["ID_METODO"].ToString());
            float monto = float.Parse(dr["TOTAL"].ToString());

            Pago pago = new Pago(monto, metodo, pedido);
            pago.Id = int.Parse(dr["ID"].ToString());
            pago.Fecha = DateTime.Parse(dr["FECHA"].ToString());

            return pago;
        }


        public Pago GetByOrderID(int id)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@id", id),
            };

            access.Open();
            DataTable dt = access.Read("OBTENER_PAGO_POR_PEDIDO", parameters);
            access.Close();

            DataRow dr = dt.Rows[0];

            return Transform(dr);

        }


        public override List<Pago> GetAll()
        {
            List<Pago> pagos = new List<Pago>();

            access.Open();
            DataTable dt = access.Read("LISTAR_PAGOS");
            access.Close();
            foreach (DataRow dr in dt.Rows)
            {
                pagos.Add(Transform(dr));
            }

            return pagos;
        }



        public override int Insert(Pago entity)
        {
            int metodoDePagoId = mpMetodo.Insert(entity.Metodo);
            if (metodoDePagoId > 0)
            {
                List<SqlParameter> pars = new List<SqlParameter>()
                {
                    access.CreateParameter("@Fecha",entity.Fecha),
                    access.CreateParameter("@Total", entity.Total),
                    access.CreateParameter("@IdMetodoDePago", metodoDePagoId),
                    access.CreateParameter("@IdPedido", entity.Pedido.NroPedido)
                };

                access.Open();
                int idPago = access.WriteScalar("INSERTAR_PAGO", pars);
                access.Close();

                return idPago;

            }

            return -1;
        }

        public override int Update(Pago entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(Pago entity)
        {
            throw new NotImplementedException();
        }

        public MP_Pago(Access access, MP_Pedido mpPedido, MP_MetodoDePago mpMetodo) : base(access)
        {
            this.mpPedido = mpPedido;
            this.mpMetodo = mpMetodo;
        }
    }
}
