using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("PAGO_INSUMO")]
    public class PagoInsumo
    {
        private int nroPago;
        private Factura factura;
        private DateTime fecha;
        private double monto;
        private TipoPago tipoPago;
        private int nroCuota;

        [ColumnMapping("NRO_PAGO")]
        public int NroPago { get => nroPago; set => nroPago = value; }

        [ColumnMapping("NRO_FACTURA")]
        public Factura Factura { get => factura; set => factura = value; }

        [ColumnMapping("FECHA")]
        public DateTime Fecha { get => fecha; set => fecha = value; }

        [ColumnMapping("MONTO")]
        public double Monto { get => monto; set => monto = value; }

        [ColumnMapping("TIPO_PAGO")]
        public TipoPago TipoPago { get => tipoPago; set => tipoPago = value; }

        [ColumnMapping("NRO_CUOTA")]
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
