using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BLL
{
    public class ControllerCajero
    {
        Pedido bllPedido = new Pedido();
        public bool RegistrarPedido(List<BE.ItemProducto> productos, BE.Cliente cliente)
        {
            BE.Pedido pedido  = new BE.Pedido();
            pedido.Productos = productos;
            pedido.Cliente = cliente;
            pedido.Estado = OrderType.Creado;
            pedido.Fecha = DateTime.Now;


            if (bllPedido.RegistrarPedido(pedido) > 0)
            {
                return true;
            }
            return false;
        }
    }
}
