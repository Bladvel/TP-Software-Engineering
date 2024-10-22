using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

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

        private List<ItemIngrediente> ingredientes;

        public List<ItemIngrediente> Ingredientes
        {
            get => ingredientes;
            set => ingredientes = value;
        }

        private string comentarios;

        public string Comentarios
        {
            get => comentarios;
            set => comentarios = value;
        }

        private EstadoSolicitudCompra estado;

        public EstadoSolicitudCompra Estado
        {
            get => estado;
            set => estado = value;
        }

        public SolicitudDeCompra(List<ItemIngrediente> ingredientes, string comentarios = "")
        {
            Fecha = DateTime.Now;
            Ingredientes = ingredientes;
            Comentarios = comentarios;
            Estado = EstadoSolicitudCompra.Pendiente;
        }

        public SolicitudDeCompra()
        {

        }

        public override string ToString()
        {
            return $"{NroSolicitud}";
        }
    }
}
