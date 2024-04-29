using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BE
{
    public class Reserva : Entity 
    {
		private Cliente cliente;

		public Cliente Cliente
		{
			get { return cliente; }
			set { cliente = value; }
		}

		private DateTime fecha_inicio;

		public DateTime Fecha_Inicio
		{
			get { return fecha_inicio; }
			set { fecha_inicio = value; }
		}

        private DateTime fecha_fin;

        public DateTime Fecha_Fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }


		private Habitacion habitacion;

		public Habitacion Habitacion
		{
			get { return habitacion; }
			set { habitacion = value; }
		}


		private int cantidad_huespedes;

		public int Cantidad_Huespedes
		{
			get { return cantidad_huespedes; }
			set { cantidad_huespedes = value; }
		}

        private int cantidad_dias;

        public int Cantidad_Dias
        {
            get { return cantidad_dias; }
            set { cantidad_dias = value; }
        }

		private string facturada;

		public string Facturada
		{
			get { return facturada; }
			set { facturada = value; }
		}

        public override string ToString()
        {
            return fecha_inicio + "-" + Fecha_Fin + ". " + cliente.Apellido + " - Habitación: " + habitacion + " - Facturada: " + facturada;	
        }


    }
}
