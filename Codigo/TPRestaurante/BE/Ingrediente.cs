using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Ingrediente
    {

        private int cod;

        public int CodIngrediente
        {
            get => cod; 
            set => cod=value;
        }

        private string nombre;

        public string Nombre
        {
            get=>nombre; 
            set=>nombre=value;
        }

        private int cantidad;

        public int Cantidad
        {
            get => cantidad;
            set => cantidad=value;
        }

        public Ingrediente(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }


    }
}
