using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("ITEM_INGREDIENTE")]
    public class ItemIngrediente
    {
        [ColumnMapping("ID")]
        public int ID { get; set; }
        private Ingrediente ingrediente;
        private SolicitudDeCotizacion solicitudDeCotizacion;
        private int cantidadRequerida;
        private float precioCotizacion;

        [ColumnMapping("COD_INGREDIENTE")]
        public Ingrediente Ingrediente
        {
            get => ingrediente;
            set => ingrediente = value;
        }

        [ColumnMapping("CANTIDAD")]
        public int CantidadRequerida
        {
            get => cantidadRequerida;
            set => cantidadRequerida = value;
        }

        [ColumnMapping("PRECIO_COTIZACION")]
        public float PrecioCotizacion
        {
            get => precioCotizacion;
            set => precioCotizacion = value;
        }

        [ColumnMapping("NRO_SOLICITUD")]
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
