using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    public class Pedido
    {
        private int nroPedido;

        public int NroPedido
        {
            get
            {
                return nroPedido;
            }
            set
            {
                nroPedido = value;
            }
        }

        private OrderType estado;

        public OrderType Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }

        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;
        }

        private List<ItemProducto> productos;
        public List<ItemProducto> Productos
        {
            get => productos;
            set => productos = value;

        }
        private Cliente cliente;

        public Cliente Cliente
        {
            get=>cliente; 
            set=>cliente=value;
        }

        public static Pedido Create(List<ItemProducto> productos, Cliente cliente)
        {
            return new Pedido
            {
                Productos = productos, 
                Cliente = cliente, 
                Fecha = DateTime.Now, 
                Estado = OrderType.Creado
            };
        }



    }

}
