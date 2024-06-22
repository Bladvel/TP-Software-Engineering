using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    public class PagoTarjeta: MetodoDePago
    {
        private long numero;
        public long NumeroTarjeta { get => numero; set=>numero=value; }

        private DateTime vencimiento;
        public DateTime FechaVencimiento { get=> vencimiento; set=> vencimiento=value; }


        private int clave;
        public int Cvv { get=>clave; set=>clave=value; }

        private string titular;
        public string Titular { get =>titular; set=>titular=value; }
    }
}
