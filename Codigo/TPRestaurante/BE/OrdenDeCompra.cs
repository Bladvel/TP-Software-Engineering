using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("ORDEN_DE_COMPRA")]
    public class OrdenDeCompra
    {
        private int nroOrden;
        private DateTime fecha;
        private Proveedor proveedor;
        private SolicitudDeCotizacion solicitud;
        //private EstadoCargaDeInsumos estadoCarga;
        private EstadoOrdenDeCompra estadoOrden;
        private string observaciones;
        private string condicionDePago;

        [ColumnMapping("NRO_ORDEN")]
        public int NroOrden { get => nroOrden; set => nroOrden = value; }

        [ColumnMapping("FECHA")]
        public DateTime Fecha { get => fecha; set => fecha = value; }

        [ColumnMapping("CUIT_PROVEEDOR")]
        public Proveedor Proveedor { get => proveedor; set => proveedor = value; }

        [ColumnMapping("NRO_SOLICITUD")]
        public SolicitudDeCotizacion Solicitud { get => solicitud; set => solicitud = value; }
        //public EstadoCargaDeInsumos EstadoCarga { get => estadoCarga; set => estadoCarga = value; }

        [ColumnMapping("ESTADO_ORDEN")]
        public EstadoOrdenDeCompra EstadoOrden { get => estadoOrden; set => estadoOrden = value; }

        [ColumnMapping("OBSERVACIONES")]
        public string Observaciones { get => observaciones; set => observaciones = value; }

        [ColumnMapping("CONDICION_PAGO")]
        public string CondicionDePago { get => condicionDePago; set => condicionDePago = value; }

        public OrdenDeCompra()
        {
            //EstadoCarga = EstadoCargaDeInsumos.NoCargados;
            EstadoOrden = EstadoOrdenDeCompra.Generada;
        }

        public OrdenDeCompra(Proveedor proveedor, SolicitudDeCotizacion solicitud, string observaciones = "", string condicionDePago = "")
        {
            Fecha = DateTime.Now;
            Proveedor = proveedor;
            Solicitud = solicitud;
            Observaciones = observaciones;
            CondicionDePago = condicionDePago;
            //EstadoCarga = EstadoCargaDeInsumos.NoCargados;
            EstadoOrden = EstadoOrdenDeCompra.Generada;
        }

        public override string ToString()
        {
            return NroOrden.ToString();
        }

    }
}
