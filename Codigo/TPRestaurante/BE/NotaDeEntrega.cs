using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    public class NotaDeEntrega
    {
        private int nroNota;
        private DateTime fecha;
        private OrdenDeCompra ordenDeCompra;
        private string observaciones;
        private EstadoNotaDeEntrega estadoNota;

        public int NroNota { get => nroNota; set => nroNota = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public OrdenDeCompra OrdenDeCompra { get => ordenDeCompra; set => ordenDeCompra = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        public EstadoNotaDeEntrega EstadoNota { get => estadoNota; set => estadoNota = value; }


        public NotaDeEntrega( DateTime fecha, OrdenDeCompra ordenDeCompra,  EstadoNotaDeEntrega estadoNota, string observaciones = "")
        {
            Fecha = fecha;
            OrdenDeCompra = ordenDeCompra;
            Observaciones = observaciones;
            EstadoNota = estadoNota;
        }

        public NotaDeEntrega(int nroNota, DateTime fecha, OrdenDeCompra ordenDeCompra, EstadoNotaDeEntrega estadoNota, string observaciones = "")
        {
            NroNota = nroNota;
            Fecha = fecha;
            OrdenDeCompra = ordenDeCompra;
            Observaciones = observaciones;
            EstadoNota = estadoNota;
        }


    }
}
