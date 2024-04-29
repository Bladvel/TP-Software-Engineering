using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Estadia : Entity 
    {
		private Factura facturaReserva;

		public Factura FacturaReserva
		{
			get { return facturaReserva; }
			set { facturaReserva = value; }
		}

		private Cliente cliente;

		public Cliente Cliente
		{
			get { return cliente; }
			set { cliente = value; }
		}

	
		private DateTime checkin;

		public DateTime Checkin
		{
			get { return checkin; }
			set { checkin = value; }
		}

		private DateTime checkout;

		public DateTime Checkout
		{
			get { return checkout; }
			set { checkout = value; }
		}

        private Habitacion habitacion;

        public Habitacion Habitacion
        {
            get { return habitacion; }
            set { habitacion = value; }
        }

		private int cantidadHuespedes;

		public int CantidadHuespedes
		{
			get { return cantidadHuespedes; }
			set { cantidadHuespedes = value; }
		}

		private EnumEstadoEstadia estado;

		public EnumEstadoEstadia Estado
		{
			get { return estado; }
			set { estado = value; }
		}


	}
}
