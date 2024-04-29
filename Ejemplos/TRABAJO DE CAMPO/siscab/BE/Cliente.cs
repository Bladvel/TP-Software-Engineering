using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente : Entity
    {
		
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		private int dni;

		public int Dni
		{
			get { return dni; }
			set { dni = value; }
		}

		private string telefono_fijo;

		public string Telefono_Fijo
		{
			get { return telefono_fijo; }
			set { telefono_fijo = value; }
		}

        private string telefono_movil;

        public string Telefono_Movil
        {
            get { return telefono_movil; }
            set { telefono_movil = value; }
        }

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private string domicilio;

		public string Domicilio
		{
			get { return domicilio; }
			set { domicilio = value; }
		}



		private int borrado;	

		public int Borrado
		{
			get { return borrado; }
			set { borrado = value; }
		}

        public override string ToString()
        {
            return nombre + " " + apellido + " - DNI: " + dni;	
        }
    }
}
