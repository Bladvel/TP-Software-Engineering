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
    public class MP_OrdenDeCompra: Mapper<BE.OrdenDeCompra>
    {
        public MP_OrdenDeCompra(Access access, MP_SolicitudDeCotizacion mpSolicitud, MP_Proveedor mpProveedor) : base(access)
        {
            this.mpSolicitud = mpSolicitud;
            this.mpProveedor = mpProveedor;
        }

        MP_SolicitudDeCotizacion mpSolicitud;
        MP_Proveedor mpProveedor;

        public override OrdenDeCompra GetById(object id)
        {
            int idOrden = (int)id;
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nro_orden", idOrden)
            };
            access.Open();
            DataTable dt = access.Read("OBTENER_ORDEN_DE_COMPRA_POR_ID", parameters);
            access.Close();
            OrdenDeCompra orden = Transform(dt.Rows[0]);
            return orden;

        }

        public override OrdenDeCompra Transform(DataRow dr)
        {
            OrdenDeCompra orden = new OrdenDeCompra();
            orden.NroOrden = int.Parse(dr["NRO_ORDEN"].ToString());
            orden.Fecha = DateTime.Parse(dr["FECHA"].ToString());
            orden.Proveedor = mpProveedor.GetById(dr["CUIT_PROVEEDOR"].ToString());
            orden.Solicitud = mpSolicitud.GetById(dr["NRO_SOLICITUD"].ToString());
            //orden.EstadoCarga = (EstadoCargaDeInsumos)Enum.Parse(typeof(EstadoCargaDeInsumos), dr["ESTADO_CARGA"].ToString());
            orden.EstadoOrden = (EstadoOrdenDeCompra)Enum.Parse(typeof(EstadoOrdenDeCompra), dr["ESTADO_ORDEN"].ToString());
            orden.Observaciones = dr["OBSERVACIONES"].ToString();
            orden.CondicionDePago = dr["CONDICION_PAGO"].ToString();
            return orden;




        }

        public override List<OrdenDeCompra> GetAll()
        {
            List<OrdenDeCompra> ordenes = new List<OrdenDeCompra>();
            access.Open();
            DataTable dt = access.Read("LISTAR_ORDEN_DE_COMPRA");
            access.Close();
            foreach (DataRow dr in dt.Rows)
            {
                ordenes.Add(Transform(dr));
            }
            return ordenes;
        }

        public override int Insert(OrdenDeCompra entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@fecha", entity.Fecha),
                access.CreateParameter("@cuit", entity.Proveedor.Cuit),
                access.CreateParameter("@nro_solicitud", entity.Solicitud.NroSolicitud),
               // access.CreateParameter("@estado_carga", entity.EstadoCarga.ToString()),
                access.CreateParameter("@estado_orden", entity.EstadoOrden.ToString()),
                access.CreateParameter("@observaciones", entity.Observaciones),
                access.CreateParameter("@condicion_pago", entity.CondicionDePago)
            };


            access.Open();
            int result = access.WriteScalar("INSERTAR_ORDEN_DE_COMPRA", parameters);
            access.Close();
            return result;


        }

        
        public override int Update(OrdenDeCompra entity)
        {
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@nro_orden", entity.NroOrden),
                access.CreateParameter("@fecha", entity.Fecha),
                access.CreateParameter("@cuit_proveedor", entity.Proveedor.Cuit),
                access.CreateParameter("@nro_solicitud", entity.Solicitud.NroSolicitud),
                //access.CreateParameter("@estado_carga", entity.EstadoCarga.ToString()),
                access.CreateParameter("@estado_orden", entity.EstadoOrden.ToString()),
                access.CreateParameter("@observaciones", entity.Observaciones),
                access.CreateParameter("@condicion_pago", entity.CondicionDePago)
            };

            access.Open();
            int result = access.Write("MODIFICAR_ORDEN_DE_COMPRA", parameters);
            access.Close();
            return result;


        }

        public List<OrdenDeCompra> GetByOrderState(EstadoOrdenDeCompra estado)
        {
            List<OrdenDeCompra> ordenes = new List<OrdenDeCompra>();
            List<SqlParameter> parameters = new List<SqlParameter>()
            {
                access.CreateParameter("@estado_orden", estado.ToString())
            };
            access.Open();
            DataTable dt = access.Read("LISTAR_ORDEN_DE_COMPRA_POR_ESTADO", parameters);
            access.Close();
            foreach (DataRow dr in dt.Rows)
            {
                ordenes.Add(Transform(dr));
            }
            return ordenes;
        }

        

        public override int Delete(OrdenDeCompra entity)
        {
            throw new NotImplementedException();
        }
    }
}
