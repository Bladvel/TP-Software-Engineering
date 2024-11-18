using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("PRODUCTO")]
    public class Producto
    {
        private int cod;

        [ColumnMapping("COD_PRODUCTO")]
        public int CodProducto
        {
            get => cod; 
            set=>cod=value;
        }

        private string descripcion;

        [ColumnMapping("DESCRIPCION")]
        public string Descripcion
        {
            get=> descripcion; 
            set=> descripcion=value;
        }

        private string nombre;

        [ColumnMapping("NOMBRE")]
        public string Nombre
        {
            get=> nombre; 
            set=> nombre=value;
        }


        private float precio;

        [ColumnMapping("PRECIO_ACTUAL")]
        public float PrecioActual
        {
            get=>precio; 
            set=>precio=value;
        }

        private List<Ingrediente> ingredientList;

        public List<Ingrediente> Ingredientes
        {
            get=> ingredientList;
            set=> ingredientList=value;
        }

        private bool borrado = false;

        [ColumnMapping("BORRADO")]
        public bool Borrado
        {
            get => borrado;
            set => borrado = value;
        }

        public Producto(string nombre, string descripcion, float precio)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            PrecioActual = precio;
        }

        public Producto()
        {

        }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }

}
