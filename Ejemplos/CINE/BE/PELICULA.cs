using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PELICULA
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private int duracion;

		public int Duracion
		{
			get { return duracion; }
			set { duracion = value; }
		}

        public override string ToString()
        {
			return $"Pelicula: {nombre}, Duracion: {duracion}";
        }



    }
}
