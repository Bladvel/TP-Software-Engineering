using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("PAGO")]
    public class Pago
    {
        private int id;

        [ColumnMapping("ID")]
        public int Id { get=>id; set=>id=value; }


        private DateTime fecha;

        [ColumnMapping("FECHA")]
        public DateTime Fecha { get => fecha; set=> fecha=value; }

        private float total;

        [ColumnMapping("TOTAL")]
        public float Total { get=>total; set=>total=value; }


        private MetodoDePago metodo;

        [ColumnMapping("ID_METODO")]
        public MetodoDePago Metodo { get=>metodo; set=>metodo=value; }

        private Pedido pedido;

        [ColumnMapping("ID_PEDIDO")]
        public Pedido Pedido { get=>pedido; set=>pedido=value; }

        public Pago(float total, MetodoDePago metodo, Pedido pedido)
        {
            Total = total;
            Metodo = metodo;
            Pedido = pedido;
        }





    }
}
