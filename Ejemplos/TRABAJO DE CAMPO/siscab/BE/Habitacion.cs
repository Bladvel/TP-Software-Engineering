using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Habitacion : Entity
    {
		public Habitacion()
		{
			disponibilidad = true;
		}
		private Tipo_Habitacion tipo;

		public Tipo_Habitacion Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}


		private int numero;

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		private bool disponibilidad;

		public bool Disponibilidad
		{
			get { return disponibilidad; }
			set { disponibilidad = value; }
		}

        public override string ToString()
        {
            return tipo + " Nº " + numero;	
        }


    }
}
