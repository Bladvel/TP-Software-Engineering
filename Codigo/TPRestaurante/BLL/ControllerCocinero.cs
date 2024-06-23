using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BLL
{
    public class ControllerCocinero
    {
        Pedido bllPedido = new Pedido();
        User bllUser = new User();
        public void RealizarComanda(BE.Comanda comanda)
        {
            // Actualizar el estado del pedido a "Listo"
            bllPedido.CambiarEstado(comanda.PedidoAsignado, OrderType.Listo);

            bllUser.UpdateAvailability(comanda.Cocinero,AvailabilityType.Disponible);

        }
    }
}
