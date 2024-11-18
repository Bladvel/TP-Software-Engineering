using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("NOTA_DE_ENTREGA")]
    public class NotaDeEntrega
    {
        private int nroNota;
        private DateTime fecha;
        private OrdenDeCompra ordenDeCompra;
        private string observaciones;
        private EstadoNotaDeEntrega estadoNota;

        [ColumnMapping("NRO_NOTA")]
        public int NroNota { get => nroNota; set => nroNota = value; }

        [ColumnMapping("FECHA")]
        public DateTime Fecha { get => fecha; set => fecha = value; }

        [ColumnMapping("NRO_ORDEN")]
        public OrdenDeCompra OrdenDeCompra { get => ordenDeCompra; set => ordenDeCompra = value; }

        [ColumnMapping("OBSERVACIONES")]
        public string Observaciones { get => observaciones; set => observaciones = value; }

        [ColumnMapping("ESTADO")]
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
