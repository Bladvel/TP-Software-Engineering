﻿using System;
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


    }
}
