using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Factura_Hospedaje : Entity
    {

        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }


        private DateTime fecha;

		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}

        private string lugar;

        public string Lugar
        {
            get { return lugar; }
            set { lugar = value; }
        }


        private Factura facturaReserva;

		public Factura FacturaReserva
		{
			get { return facturaReserva; }
			set { facturaReserva = value; }
		}



		private Estadia estadia;

		public Estadia Estadia
		{
			get { return estadia; }
			set { estadia = value; }
		}

		private Cliente cliente;

		public Cliente Cliente
		{
			get { return cliente; }
			set { cliente = value; }
		}

        private float totalPagar;

        public float TotalPagar
        {
            get { return totalPagar; }
            set { totalPagar = value; }
        }

		

		private float deposito;

		public float Deposito
		{
			get { return deposito; }
			set { deposito = value; }
		}



		private float totalEstadia;

		public float TotalEstadia
		{
			get { return totalEstadia; }
			set { totalEstadia = value; }
		}

        private EnumEstadoPago estado;

        public EnumEstadoPago Estado
        {
            get { return estado; }
            set { estado = value; }
        }


    }
}
