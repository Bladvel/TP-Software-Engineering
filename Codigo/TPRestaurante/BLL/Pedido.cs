using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using DAL.FactoryMapper;
using Interfaces;

namespace BLL
{
    public class Pedido
    {
        MP_Pedido mp = MpPedidoCreator.GetInstance.CreateMapper() as MP_Pedido;
        
        public void CambiarEstado(BE.Pedido pedido, OrderType estado)
        {
            pedido.Estado = estado;
            mp.Update(pedido);
        }

        public void CambiarEstado(BE.Pedido pedido, PaymentState pagado)
        {
            pedido.EstadoPago = pagado;
            mp.Update(pedido);
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


        public int RegistrarPedido(BE.Pedido pedido)
        {
            return mp.Insert(pedido);
        }


        public List<BE.Pedido> ListarPorEstado(OrderType estado)
        {
            return mp.GetOrderByState(estado);
        }

        public List<BE.Pedido> ListarPorPago(PaymentState estado)
        {
            return mp.GetOrderByPaymentState(estado);
        }

        public string Concatenar(BE.Pedido pedido)
        {
            return pedido.NroPedido + pedido.Estado + pedido.Fecha.ToString() + pedido.Cliente.ID + pedido.EstadoPago;
        }

        public List<BE.Pedido> Listar()
        {
            return mp.GetAll();


        }

    }
}
