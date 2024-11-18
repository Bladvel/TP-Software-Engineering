using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("SOLICITUD_DE_COMPRA")]
    public class SolicitudDeCotizacion
    {
        private int nro;

        [ColumnMapping("NRO_SOLICITUD")]
        public int NroSolicitud
        {
            get => nro;
            set => nro = value;
        }

        private DateTime fecha;

        [ColumnMapping("FECHA")]
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

        [ColumnMapping("COMENTARIOS")]
        public string Comentarios
        {
            get => comentarios;
            set => comentarios = value;
        }

        private EstadoSolicitudCotizacion estado;

        [ColumnMapping("ESTADO")]
        public EstadoSolicitudCotizacion Estado
        {
            get => estado;
            set => estado = value;
        }

        public SolicitudDeCotizacion(List<ItemIngrediente> ingredientes, string comentarios = "")
        {
            Fecha = DateTime.Now;
            Ingredientes = ingredientes;
            Comentarios = comentarios;
            Estado = EstadoSolicitudCotizacion.Pendiente;
        }

        public SolicitudDeCotizacion()
        {

        }

        public override string ToString()
        {
            return $"{NroSolicitud}";
        }
    }
}
