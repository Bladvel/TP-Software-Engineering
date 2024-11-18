using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using DAL.FactoryMapper;
using Interfaces;
using Services;

namespace BLL
{
    public class Pedido
    {
        MP_Pedido mp = MpPedidoCreator.GetInstance.CreateMapper() as MP_Pedido;
        
        public void CambiarEstado(BE.Pedido pedido, OrderType estado)
        {
            pedido.Estado = estado;
            int resultado = mp.Update(pedido);
            if (resultado != -1)
            {
                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Pedido,
                    Operacion = TipoOperacion.Modificacion,
                    Criticidad = 3
                };

                BLL.Bitacora bllBitacora = new BLL.Bitacora();
                bllBitacora.Insertar(logEntry);
                DVH.Recalcular(DVH.Listar(), Listar(), Concatenar, p => p.NroPedido, "PEDIDO");
                DVV.Recalcular(Listar().Cast<object>().ToList(), typeof(BE.Pedido));
            }
        }

        public void CambiarEstado(BE.Pedido pedido, PaymentState pagado)
        {
            pedido.EstadoPago = pagado;
            int resultado = mp.Update(pedido);
            if (resultado != -1)
            {
                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Pedido,
                    Operacion = TipoOperacion.Modificacion,
                    Criticidad = 3
                };

                BLL.Bitacora bllBitacora = new BLL.Bitacora();
                bllBitacora.Insertar(logEntry);
                DVH.Recalcular(DVH.Listar(), Listar(), Concatenar, p => p.NroPedido, "PEDIDO");
                DVV.Recalcular(Listar().Cast<object>().ToList(), typeof(BE.Pedido));
            }
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
            int resultado = mp.Insert(pedido);

            if (resultado != -1)
            {
                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Pedido,
                    Operacion = TipoOperacion.Alta,
                    Criticidad = 2
                };

                BLL.Bitacora bllBitacora = new BLL.Bitacora();
                bllBitacora.Insertar(logEntry);

                DVH.Recalcular(DVH.Listar(), Listar(),Concatenar, p => p.NroPedido, "PEDIDO");
                DVV.Recalcular(Listar().Cast<object>().ToList(), typeof(BE.Pedido));


            }


            return resultado;
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
