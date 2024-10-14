using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class SolicitudDeCompra
    {
        private int nro;

        public int NroSolicitud
        {
            get => nro;
            set => nro = value;
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;
        }

        private List<Ingrediente> ingredientes;

        public List<Ingrediente> Ingredientes
        {
            get => ingredientes;
            set => ingredientes = value;
        }

        public SolicitudDeCompra(DateTime fecha, List<Ingrediente> ingredientes)
        {
            Fecha = fecha;
            Ingredientes = ingredientes;
        }

        public SolicitudDeCompra()
        {

        }
    }
}
