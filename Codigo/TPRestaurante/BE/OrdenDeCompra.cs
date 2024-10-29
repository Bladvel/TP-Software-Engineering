using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
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

        public int NroOrden { get => nroOrden; set => nroOrden = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Proveedor Proveedor { get => proveedor; set => proveedor = value; }
        public SolicitudDeCotizacion Solicitud { get => solicitud; set => solicitud = value; }
        //public EstadoCargaDeInsumos EstadoCarga { get => estadoCarga; set => estadoCarga = value; }
        public EstadoOrdenDeCompra EstadoOrden { get => estadoOrden; set => estadoOrden = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
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
