using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Interfaces;

namespace BLL
{
    public class Pedido
    {
        MP_Pedido mp = new MP_Pedido();
        public void CambiarEstado(BE.Pedido pedido, OrderType estado)
        {
            pedido.Estado = estado;
        }

        public float CalcularSubtotal(BE.Pedido pedido)
        {
            float subtotal = 0;

            foreach (var item in pedido.Productos)
            {
                subtotal += item.Cantidad * item.PrecioCompra;
            }


            return subtotal;
        }

        public void AgregarItem(BE.Pedido pedido, ItemProducto item)
        {
            pedido.Productos.Add(item);
        }

        public int RegistrarPedido(BE.Pedido pedido)
        {
           return mp.Insert(pedido);
        }

        public List<BE.Pedido> Listar()
        {
            return mp.GetAll();
        }

        public List<BE.Pedido> ListarPorEstado(OrderType estado)
        {
            return mp.GetOrderByState(estado);
        }

    }
}
