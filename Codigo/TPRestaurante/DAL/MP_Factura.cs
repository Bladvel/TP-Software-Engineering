using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BE;
using Interfaces;

namespace DAL
{
    public class MP_Factura: Mapper<BE.Factura>
    {
        public MP_Factura(Access access, MP_OrdenDeCompra mpOrdenDeCompra, MP_PagoInsumo mpPagoInsumo) : base(access)
        {
            this.mpOrdenDeCompra = mpOrdenDeCompra;
            this.mpPagoInsumo = mpPagoInsumo;
        }

        private MP_OrdenDeCompra mpOrdenDeCompra;
        private MP_PagoInsumo mpPagoInsumo;


        public override List<BE.Factura> GetAll()
        {
            List<BE.Factura> facturas = new List<BE.Factura>();
            access.Open();
            DataTable tabla = access.Read("LISTAR_FACTURA");
            access.Close();
            foreach (DataRow dr in tabla.Rows)
                facturas.Add(Transform(dr));
            return facturas;
        }

        public override BE.Factura GetById(object id)
        {
            int nroFactura = int.Parse(id.ToString());

            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nro_factura", nroFactura)
            };

            access.Open();
            DataTable tabla = access.Read("OBTENER_FACTURA_POR_ID", parameters);
            access.Close();
            return Transform(tabla.Rows[0]);


        }

        public override int Insert(BE.Factura entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@fecha", entity.Fecha),
                access.CreateParameter("@nro_orden", entity.OrdenDeCompra.NroOrden),
                access.CreateParameter("@total_cuotas", entity.TotalCuotas),
                access.CreateParameter("@monto", entity.MontoTotal),
                access.CreateParameter("@estado", entity.Estado.ToString())
            };

            access.Open();
            int result = access.WriteScalar("INSERTAR_FACTURA", parameters);
            access.Close();
            return result;
        }

        public override BE.Factura Transform(DataRow dr)
        {
            Factura factura = new Factura();
            factura.NroFactura = int.Parse(dr["NRO_FACTURA"].ToString());
            factura.Fecha = DateTime.Parse(dr["FECHA"].ToString());
            factura.OrdenDeCompra = mpOrdenDeCompra.GetById(int.Parse(dr["NRO_ORDEN"].ToString()));
            factura.TotalCuotas = int.Parse(dr["TOTAL_CUOTAS"].ToString());
            factura.MontoTotal = double.Parse(dr["MONTO"].ToString());
            factura.Estado = (EstadoFactura)Enum.Parse(typeof(EstadoFactura), dr["ESTADO"].ToString());
            factura.Pagos = mpPagoInsumo.GetByFactura(factura.NroFactura);
            return factura;

        }

        public override int Update(BE.Factura entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nro_factura", entity.NroFactura),
                access.CreateParameter("@fecha", entity.Fecha),
                access.CreateParameter("@nro_orden", entity.OrdenDeCompra.NroOrden),
                access.CreateParameter("@total_cuotas", entity.TotalCuotas),
                access.CreateParameter("@monto", entity.MontoTotal),
                access.CreateParameter("@estado", entity.Estado.ToString())
            };

            access.Open();
            int result = access.Write("MODIFICAR_FACTURA", parameters);
            access.Close();
            return result;

        }

        public override int Delete(BE.Factura entity)
        {
            throw new NotImplementedException();
        }
    }
    

    
}
