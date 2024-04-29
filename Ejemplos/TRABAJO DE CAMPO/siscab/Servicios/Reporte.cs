using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Reporte
    {

        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private List<BE.Factura> facturas;

        public List<BE.Factura> Facturas
        {
            get { return facturas; }
            set { facturas = value; }
        }

        

        private float totalDepositoReservas;

        public float TotalDepositoReservas
        {
            get { return totalDepositoReservas; }
            set { totalDepositoReservas = value; }
        }
       

        private List<Factura_Hospedaje> facturasHospedajes;

		public List<Factura_Hospedaje> FacturasHospedajes
		{
			get { return facturasHospedajes; }
			set { facturasHospedajes = value; }
		}


		private float totalRestoEstadia;

		public float TotalRestoEstadia
		{
			get { return totalRestoEstadia; }
			set { totalRestoEstadia = value; }
		}

        private List<Estadia> estadias;

        public List<Estadia> Estadias
        {
            get { return estadias; }
            set { estadias = value; }
        }

        


    }
}
