using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Comanda
    {
        private int id;
        public int ID
        {
            get => id; 
            set => id = value;
        }

        private string descripcion;
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private Pedido pedido;
        public Pedido PedidoAsignado
        {
            get => pedido; 
            set => pedido=value;
        }

        private User cocinero;
        public User Cocinero
        {
            get => cocinero;
            set => cocinero = value;
        }

        public Comanda(Pedido pedido, User cocinero, string descripcion = "")
        {
            PedidoAsignado = pedido;
            Cocinero = cocinero;
            Descripcion = descripcion;
        }


    }
}
