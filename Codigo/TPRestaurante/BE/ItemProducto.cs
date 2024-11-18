using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("ITEM_PRODUCTO")]
    public class ItemProducto
    {
        [ColumnMapping("ID")]
        public int Id { get; set; }

        [ColumnMapping("CANTIDAD")]
        public int Cantidad { get; set; }

        [ColumnMapping("PRECIO_COMPRA")]
        public float PrecioCompra { get; set; }

        [ColumnMapping("COD_PRODUCTO")]
        public Producto Producto { get; set; }

        [ColumnMapping("NRO_PEDIDO")]
        public Pedido Pedido { get; set; }

        public ItemProducto(int cantidad, float precioCompra, Producto producto)
        {
            Cantidad = cantidad;
            PrecioCompra = precioCompra;
            Producto = producto;
        }

        public ItemProducto()
        {
        }

        public override string ToString()
        {
            return $"{Producto.Nombre} | Precio: ${PrecioCompra} x {Cantidad}u";
        }

    }
}
