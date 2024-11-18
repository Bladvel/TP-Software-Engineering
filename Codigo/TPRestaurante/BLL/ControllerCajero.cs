using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Interfaces;
using Services;

namespace BLL
{
    public class ControllerCajero
    {
        Pedido bllPedido = new Pedido();
        ItemProducto bllItemProducto = new ItemProducto();
        Pago bllPago = new Pago();
        //DVH bllDvh = new DVH();
        Bitacora bllBitacora = new Bitacora();
        public bool RegistrarPedido(List<BE.ItemProducto> productos, BE.Cliente cliente)
        {
            BE.Pedido pedido  = new BE.Pedido();
            pedido.Productos = productos;
            pedido.Cliente = cliente;
            pedido.Estado = OrderType.Creado;
            pedido.Fecha = DateTime.Now;


            if (bllPedido.RegistrarPedido(pedido) > 0)
            {
                DVH.Recalcular(DVH.Listar(), bllItemProducto.Listar(), bllItemProducto.Concatenar, p => p.Id, "ITEM_PRODUCTO");
                DVV.Recalcular(bllItemProducto.Listar().Cast<object>().ToList(), typeof(BE.ItemProducto));
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
               
               DVH.Recalcular(DVH.Listar(), bllMetodoDePago.Listar(), bllMetodoDePago.Concatenar, c => c.id, "METODO_DE_PAGO");
               DVH.Recalcular(DVH.Listar(), bllPagoEfectivo.Listar(), bllPagoEfectivo.Concatenar, c => c.id, "PAGO_EFECTIVO");
               DVH.Recalcular(DVH.Listar(), bllPagoTarjeta.Listar(), bllPagoTarjeta.Concatenar, c => c.id, "PAGO_TARJETA");

               DVV.Recalcular(bllMetodoDePago.Listar().Cast<object>().ToList(), typeof(BE.MetodoDePago));
               DVV.Recalcular(bllPagoEfectivo.Listar().Cast<object>().ToList(), typeof(BE.PagoEfectivo));
               DVV.Recalcular(bllPagoTarjeta.Listar().Cast<object>().ToList(), typeof(BE.PagoTarjeta));



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

                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Pedido,
                    Operacion = TipoOperacion.CerrarPedidos,
                    Criticidad = 4
                };


                bllBitacora.Insertar(logEntry);


            }

            return resultado;
        }
    }
}
