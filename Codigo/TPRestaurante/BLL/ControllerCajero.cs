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
        Pago bllPago = new Pago();
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

        public int RealizarCobro(MetodoDePago metodoDePago, BE.Pedido pedidoSeleccionado)
        {

            float total = bllPedido.CalcularSubtotal(pedidoSeleccionado);


            BE.Pago nuevoPago = new BE.Pago(total, metodoDePago, pedidoSeleccionado)
            {
                Fecha = DateTime.Now,
            };
            int idPago = -1;
            if (bllPago.ProcesarPago(nuevoPago))
            {
               idPago= bllPago.Insertar(nuevoPago);

               bllPedido.CambiarEstado(pedidoSeleccionado,PaymentState.Pagado);
            }

            return idPago;
        }

        public bool CerrarPedido(BE.Pedido pedido)
        {
            bool resultado = pedido.EstadoPago == PaymentState.Pagado && pedido.Estado == OrderType.Listo;
            if (resultado)
            {
                bllPedido.CambiarEstado(pedido, OrderType.Entregado);
            }

            return resultado;
        }
    }
}
