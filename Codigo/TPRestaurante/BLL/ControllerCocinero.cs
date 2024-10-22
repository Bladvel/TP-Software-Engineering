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
        DVH bllDvh = new DVH();
        public void RealizarComanda(BE.Comanda comanda)
        {
            // Actualizar el estado del pedido a "Listo"
            bllPedido.CambiarEstado(comanda.PedidoAsignado, OrderType.Listo);
            bllDvh.Recalcular(bllDvh.Listar(), bllPedido.Listar(), bllPedido.Concatenar, p => p.NroPedido, "PEDIDO");


            bllUser.UpdateAvailability(comanda.Cocinero,AvailabilityType.Disponible);

        }
    }
}
