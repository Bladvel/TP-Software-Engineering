using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ItemProducto
    {
        public string Concatenar(BE.ItemProducto item)
        {
            return item.Producto.CodProducto + item.Pedido.NroPedido + item.Cantidad + item.PrecioCompra.ToString();
        }
    }
}
