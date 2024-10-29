using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    public class Factura
    {
        private int nroFactura;
        private DateTime fecha;
        private OrdenDeCompra ordenDeCompra;
        private int totalCuotas;
        private double montoTotal;
        private EstadoFactura estado;
        private List<PagoInsumo> pagos = null;

        public int NroFactura { get => nroFactura; set => nroFactura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public OrdenDeCompra OrdenDeCompra { get => ordenDeCompra; set => ordenDeCompra = value; }
        public int TotalCuotas { get => totalCuotas; set => totalCuotas = value; }
        public double MontoTotal { get => montoTotal; set => montoTotal = value; }
        public EstadoFactura Estado { get => estado; set => estado = value; }
        public List<PagoInsumo> Pagos { get => pagos; set => pagos = value; }
        public Factura()
        {
            Estado = EstadoFactura.Pendiente;
        }

        public Factura(DateTime fecha, OrdenDeCompra ordenDeCompra, double montoTotal, int totalCuotas = 1)
        {
            Fecha = fecha;
            OrdenDeCompra = ordenDeCompra;
            TotalCuotas = totalCuotas;
            MontoTotal = montoTotal;
            Estado = EstadoFactura.Pendiente;
        }


    }
}
