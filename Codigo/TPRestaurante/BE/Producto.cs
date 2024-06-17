using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        public int CodProducto { get; set; }
        public string Descripcion { get; set; }
        public string Nombre { get; set; }
        public int CantStock { get; set; }
        public float PrecioActual { get; set; }

        public static Producto CrearProducto(float precio, string nombre, string descripcion)
        {
            return new Producto { PrecioActual = precio, Nombre = nombre, Descripcion = descripcion };
        }

        public override string ToString()
        {
            return $"{Nombre} | Precio: ${PrecioActual}";
        }
    }

}
