using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Factura : Entity
    {        
        private string numero;

		public string Numero
		{
			get { return numero; }
			set { numero = value; }
		}


		private Cliente cliente;

		public Cliente Cliente
		{
			get { return cliente; }
			set { cliente = value; }
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
		
		private Reserva reserva;

		public Reserva Reserva		
		{
			get { return reserva; }
			set { reserva = value; }
		}

		private float subtotal;

		public float Subtotal
		{
			get { return subtotal; }
			set { subtotal = value; }
		}


		private float iva;

		public float Iva
		{
			get { return iva; }
			set { iva = value; }
		}

		private float total;

		public float Total
		{
			get { return total; }
			set { total = value; }
		}

		private float deposito;

		public float Deposito
		{
			get { return deposito; }
			set { deposito = value; }
		}

        public override string ToString()
        {
            return "Número: " + numero;	
        }

    }
}
