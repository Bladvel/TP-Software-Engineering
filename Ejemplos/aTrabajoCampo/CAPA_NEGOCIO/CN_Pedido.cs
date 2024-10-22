using CAPA_DATOS;
using CAPA_DATOS.DAOs;
using CAPA_ENTIDADES;
using Seguridad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_NEGOCIO
{
    public class CN_Pedido
    {
        private static CN_Pedido instance;

        public static CN_Pedido GetInstance()
        {
            if(instance == null)
            {
                instance = new CN_Pedido();
            }

            return instance;
        }

        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;
            try
            {
                idCorrelativo = CD_Pedido.GetInstance().ObtenerCorrelativo();
            }
            catch (Exception)
            {
                idCorrelativo = 0;
            }
            return idCorrelativo;
        }

        public bool SumarStock(int idArticulo, int cantidad)
        {
            bool respuesta = false;

            try
            {
                respuesta = CD_Pedido.GetInstance().SumarStock(idArticulo, cantidad);
            }
            catch (Exception)
            {
                respuesta = false;
                throw;
            }

            return respuesta;
        }

        public bool RestarStock(int idArticulo, int cantidad)
        {
            bool respuesta = false;

            try
            {
                respuesta = CD_Pedido.GetInstance().RestarStock(idArticulo, cantidad);
            }
            catch (Exception)
            {
                respuesta = false;
                throw;
            }

            return respuesta;
        }

        public bool Registrar(Pedido obj, DataTable detallePedido, out string msj)
        {
            msj = string.Empty;
            obj.oEstadoPedido = new EstadoPedido() { IdEstadoPedido = 1 };

            obj.DVH = DigitosVerificador.CalcularDVH(obj);

            bool resultado = CD_Pedido.GetInstance().Registrar(obj,detallePedido, out msj);

            if (resultado)
            {
                ActualizarDVV();
                msj = "Pedido Creado con exito";
            }

            return resultado;
            
        }


        private void ActualizarDVV()
        {
            try
            {
                var pedidos = CD_Pedido.GetInstance().GetAll();

                // Log de los DVH actuales para asegurarte de que los valores sean correctos
                foreach (var pedido in pedidos)
                {
                    Console.WriteLine($"DVH: {pedido.DVH}");
                }

                // Llama a la función que actualiza el DVV usando la entidad actual
                DigitosVerificador.ActualizardDVV(() => pedidos, "Pedido");
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el DVV", ex);
            }
        }

        public Pedido ObtenerPedido(string numero)
        {
            Pedido pedido = DAOs_Pedido.GetInstance().ObtenerPedido(numero);

            if (pedido.IdPedido != 0)
            {
                List<DetallePedido> detallePedido = DAOs_Pedido.GetInstance().ObtenerDetallePedido(pedido.IdPedido);
                pedido.oDetallePedido = detallePedido;
            }
            return pedido;
        }

    }
}
