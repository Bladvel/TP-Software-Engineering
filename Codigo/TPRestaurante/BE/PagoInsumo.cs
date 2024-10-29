using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    public class PagoInsumo
    {
        private int nroPago;
        private Factura factura;
        private DateTime fecha;
        private double monto;
        private TipoPago tipoPago;
        private int nroCuota;

        public int NroPago { get => nroPago; set => nroPago = value; }
        public Factura Factura { get => factura; set => factura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public double Monto { get => monto; set => monto = value; }
        public TipoPago TipoPago { get => tipoPago; set => tipoPago = value; }
        public int NroCuota { get => nroCuota; set => nroCuota = value; }
        public PagoInsumo()
        {
        }

        public PagoInsumo(Factura factura, double monto, TipoPago tipoPago, int nroCuota)
        {
            Factura = factura;
            Fecha = DateTime.Now;
            Monto = monto;
            TipoPago = tipoPago;
            NroCuota = nroCuota;
        }

        public override string ToString()
        {
            return NroPago.ToString();
        }
    }
}
