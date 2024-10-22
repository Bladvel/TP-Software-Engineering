using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ItemProducto
    {
        public int Id { get; set; }

        public int Cantidad { get; set; }
        public float PrecioCompra { get; set; }

        public Producto Producto { get; set; }

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
