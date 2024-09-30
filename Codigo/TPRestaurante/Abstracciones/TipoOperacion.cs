using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public enum TipoOperacion
    {
        Todos,
        Login,
        LoginIncorrecto,
        LoginUsuarioBloqueado,
        BloqueoDeUsuario,
        Logout,
        Alta,
        Baja,
        Modificacion,
        Consulta,
        DesbloquearUsuario,
        CambiarContraseña,
        CrearOrden,
        VerPedidos,
        CobrarPedido,
        VerComanda,
        GenerarComanda,
        AceptarPedido,
        RechazarPedido,
        CerrarPedidos,
        NotificarPedidoListo,
        GenerarBitacora,
    }
}
