using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ItemIngrediente
    {
        public int ID { get; set; }
        private Ingrediente ingrediente;
        private SolicitudDeCotizacion solicitudDeCotizacion;
        private int cantidadRequerida;
        private float precioCotizacion;

        public Ingrediente Ingrediente
        {
            get => ingrediente;
            set => ingrediente = value;
        }

        public int CantidadRequerida
        {
            get => cantidadRequerida;
            set => cantidadRequerida = value;
        }

        public float PrecioCotizacion
        {
            get => precioCotizacion;
            set => precioCotizacion = value;
        }

        public SolicitudDeCotizacion SolicitudDeCotizacion
        {
            get => solicitudDeCotizacion;
            set => solicitudDeCotizacion = value;
        }

        public ItemIngrediente(Ingrediente ingrediente, int cantidad)
        {
            Ingrediente = ingrediente;
            CantidadRequerida = cantidad;
        }

        public ItemIngrediente()
        {

        }
    }
}
