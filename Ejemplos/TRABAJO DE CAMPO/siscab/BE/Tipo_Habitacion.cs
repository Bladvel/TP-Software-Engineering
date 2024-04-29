using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tipo_Habitacion : Entity
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private int huespedes_maximo;

		public int Huespedes_Maximo
		{
			get { return huespedes_maximo; }
			set { huespedes_maximo = value; }
		}

		private float precio;

		public float Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		public override string ToString()
		{
			return nombre;
		}

	}
}
