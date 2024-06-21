using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    public class Pago
    {
        private int id;
        public int Id { get=>id; set=>id=value; }

        private DateTime fecha;
        public DateTime Fecha { get => fecha; set=> fecha=value; }

        private float total;
        public float Total { get=>total; set=>total=value; }


        private MetodoDePago metodo;
        public MetodoDePago Metodo { get=>metodo; set=>metodo=value; }

        private Pedido pedido;
        public Pedido Pedido { get=>pedido; set=>pedido=value; }

        public Pago(float total, MetodoDePago metodo, Pedido pedido)
        {
            Total = total;
            Metodo = metodo;
            Pedido = pedido;
        }





    }
}
