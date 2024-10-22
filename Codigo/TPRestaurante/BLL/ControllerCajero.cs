using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Interfaces;

namespace BLL
{
    public class ControllerCajero
    {
        Pedido bllPedido = new Pedido();
        ItemProducto bllItemProducto = new ItemProducto();
        Pago bllPago = new Pago();
        DVH bllDvh = new DVH();
        public bool RegistrarPedido(List<BE.ItemProducto> productos, BE.Cliente cliente)
        {
            BE.Pedido pedido  = new BE.Pedido();
            pedido.Productos = productos;
            pedido.Cliente = cliente;
            pedido.Estado = OrderType.Creado;
            pedido.Fecha = DateTime.Now;


            if (bllPedido.RegistrarPedido(pedido) > 0)
            {
                bllDvh.Recalcular(bllDvh.Listar(), bllPedido.Listar(), bllPedido.Concatenar,p=>p.NroPedido, "PEDIDO");
                bllDvh.Recalcular(bllDvh.Listar(), bllItemProducto.Listar(), bllItemProducto.Concatenar,p=>p.Id, "ITEM_PRODUCTO");
                return true;
            }
            return false;
        }



        MetodoDePago bllMetodoDePago = new MetodoDePago();
        PagoEfectivo bllPagoEfectivo = new PagoEfectivo();
        PagoTarjeta bllPagoTarjeta = new PagoTarjeta();

        public int RealizarCobro(BE.MetodoDePago metodoDePago, BE.Pedido pedidoSeleccionado)
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
               bllDvh.Recalcular(bllDvh.Listar(), bllPago.Listar(), bllPago.Concatenar, c => c.Id, "PAGO");
               bllDvh.Recalcular(bllDvh.Listar(), bllMetodoDePago.Listar(), bllMetodoDePago.Concatenar, c => c.id, "METODO_DE_PAGO");
               bllDvh.Recalcular(bllDvh.Listar(), bllPagoEfectivo.Listar(), bllPagoEfectivo.Concatenar, c => c.id, "PAGO_EFECTIVO");
               bllDvh.Recalcular(bllDvh.Listar(), bllPagoTarjeta.Listar(), bllPagoTarjeta.Concatenar, c => c.id, "PAGO_TARJETA");
               
               bllPedido.CambiarEstado(pedidoSeleccionado,PaymentState.Pagado);
               bllDvh.Recalcular(bllDvh.Listar(), bllPedido.Listar(), bllPedido.Concatenar, p => p.NroPedido, "PEDIDO");
            }

            return idPago;
        }

        public bool CerrarPedido(BE.Pedido pedido)
        {
            bool resultado = pedido.EstadoPago == PaymentState.Pagado && pedido.Estado == OrderType.Listo;
            if (resultado)
            {
                bllPedido.CambiarEstado(pedido, OrderType.Entregado);
                bllDvh.Recalcular(bllDvh.Listar(), bllPedido.Listar(), bllPedido.Concatenar, p => p.NroPedido, "PEDIDO");
            }

            return resultado;
        }
    }
}
