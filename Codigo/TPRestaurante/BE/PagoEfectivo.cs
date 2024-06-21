using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    public class PagoEfectivo: MetodoDePago
    {
        private float monto;
        public float Monto { get { return monto; } set { monto = value; } }


    }
}
