using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("PAGO_TARJETA")]
    public class PagoTarjeta: MetodoDePago
    {
        [ColumnMapping("ID")]
        public override int id { get; set; }

        private long numero;

        [ColumnMapping("NUMERO")]
        public long NumeroTarjeta { get => numero; set=>numero=value; }

        private DateTime vencimiento;

        [ColumnMapping("VENCIMIENTO")]
        public DateTime FechaVencimiento { get=> vencimiento; set=> vencimiento=value; }


        private int clave;

        [ColumnMapping("CVV")]
        public int Cvv { get=>clave; set=>clave=value; }

        private string titular;

        [ColumnMapping("TITULAR")]
        public string Titular { get =>titular; set=>titular=value; }
    }
}
