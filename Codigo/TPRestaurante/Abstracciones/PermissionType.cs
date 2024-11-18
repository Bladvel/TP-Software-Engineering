using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public enum PermissionType
    {
        Default,
        CrearPedido,
        VerPedidos,
        CobrarPedido,
        VerProductos,
        VerIngredientes,
        NotificarPedidoListo,
        VerificarPedido,
        GenerarComanda,
        VerComanda,
        GestorUsuario,
        GestorPerfil,
        GestorIdioma,
        GestionarAdmin,
        GestionarCatalogos,
        GestionarPedido,
        GestionarComanda,
        VerPedidosRegistrados,
        VerPedidosEnCurso,
        VerPedidosCerrados,
        VerPedidosVerificados,
        VerPedidosListos,
        GestionarMaestros, //de aqui en adelante agregar a la base de datos
        GestionarClientes,
        GestionarProductos,
        GestionarCompras,
        GestionarCotizaciones,
        VerGestionarCotizaciones,
        VerEnviarCotizaciones,
        GestionarOrdenesDeCompra,
        VerGenerarOrdenesDeCompra,
        VerGestionarOrdenesDeCompra,
        GestionarGestionDePagos,
        VerCargarFacturas,
        VerRegistrarPagos,
        VerReportes,
        
    }
}
