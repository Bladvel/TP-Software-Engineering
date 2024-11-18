using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Services;

namespace BLL
{
    public class ControllerCocinero
    {
        Pedido bllPedido = new Pedido();
        User bllUser = new User();
        //DVH bllDvh = new DVH();
        Bitacora bllBitacora = new Bitacora();
        public void RealizarComanda(BE.Comanda comanda)
        {
            // Actualizar el estado del pedido a "Listo"
            bllPedido.CambiarEstado(comanda.PedidoAsignado, OrderType.Listo);
            

            var logUser = SessionManager.Instance.User;
            var logEntry = new Services.Bitacora
            {
                Usuario = logUser,
                Fecha = DateTime.Now,
                Modulo = TipoModulo.Comanda,
                Operacion = TipoOperacion.RealizarComanda,
                Criticidad = 4
            };


            bllBitacora.Insertar(logEntry);



            bllUser.UpdateAvailability(comanda.Cocinero,AvailabilityType.Disponible);

        }
    }
}
