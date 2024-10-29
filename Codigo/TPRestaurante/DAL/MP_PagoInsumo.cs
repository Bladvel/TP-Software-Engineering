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
    public class MP_PagoInsumo: Mapper<BE.PagoInsumo>
    {
        public MP_PagoInsumo(Access access) : base(access)
        {
            
        }


        public override PagoInsumo GetById(object id)
        {
            throw new NotImplementedException();
        }

        public override PagoInsumo Transform(DataRow dr)
        {
            PagoInsumo pago = new PagoInsumo();
            pago.NroPago = int.Parse(dr["NRO_PAGO"].ToString());
            pago.Factura = new Factura();
            pago.Factura.NroFactura = int.Parse(dr["NRO_FACTURA"].ToString());
            pago.Fecha = DateTime.Parse(dr["FECHA"].ToString());
            pago.Monto = double.Parse(dr["MONTO"].ToString());
            pago.TipoPago = (TipoPago)Enum.Parse(typeof(TipoPago), dr["TIPO_PAGO"].ToString());
            pago.NroCuota = int.Parse(dr["NRO_CUOTA"].ToString());
            return pago;
        }

        public override List<PagoInsumo> GetAll()
        {
            throw new NotImplementedException();
        }

        public override int Insert(PagoInsumo entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nro_factura", entity.Factura.NroFactura),
                access.CreateParameter("@fecha", entity.Fecha),
                access.CreateParameter("@monto", entity.Monto),
                access.CreateParameter("@tipo_pago", entity.TipoPago.ToString()),
                access.CreateParameter("@nro_cuota", entity.NroCuota)
            };
            access.Open();
            int result = access.WriteScalar("INSERTAR_PAGO_INSUMO", parameters);
            access.Close();
            return result;
        }

        public override int Update(PagoInsumo entity)
        {
            throw new NotImplementedException();
        }

        public override int Delete(PagoInsumo entity)
        {
            throw new NotImplementedException();
        }

        public List<PagoInsumo> GetByFactura(int facturaId)
        {
            List<PagoInsumo> pagos = new List<PagoInsumo>();
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nro_factura", facturaId),
            };
            access.Open();
            DataTable dt = access.Read("LISTAR_PAGO_INSUMO_POR_FACTURA", parameters);
            access.Close();
            foreach (DataRow dr in dt.Rows)
            {
                pagos.Add(Transform(dr));
            }
            return pagos;
        }

    }
}
