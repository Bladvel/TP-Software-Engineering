using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("PAGO_EFECTIVO")]
    public class PagoEfectivo: MetodoDePago
    {
        [ColumnMapping("ID")]
        public override int id { get; set; }

        private float monto;

        [ColumnMapping("MONTO")]
        public float Monto { get { return monto; } set { monto = value; } }


    }
}
