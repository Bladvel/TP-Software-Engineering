using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Pago_Deposito : Entity
    {

		private Tipo_Tarjeta tipo;

		public Tipo_Tarjeta Tipo
		{
			get { return tipo; }
			set { tipo = value; }
		}

        private Procesador_Pago procesador;
        public Procesador_Pago Procesador
        {
            get { return procesador; }
            set { procesador = value; }
        }


		private Banco banco;

		public Banco Banco
		{
			get { return banco; }
			set { banco = value; }
		}

		private Int64 numero;

		public Int64 Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		
		private int codigo;

		public int Codigo
		{
			get { return codigo; }
			set { codigo = value; }
		}

		private DateTime vencimiento;

		public DateTime Vencimiento
		{
			get { return vencimiento; }
			set { vencimiento = value; }
		}

		private Factura factura;

		public Factura Factura
		{
			get { return factura; }
			set { factura = value; }
		}

		private int cuotas;

		public int Cuotas
		{
			get { return cuotas; }
			set { cuotas = value; }
		}

	}
}
