using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Pago
    {
        MP_Pago mp = new MP_Pago();

        public int Insertar(BE.Pago pago)
        {
            return mp.Insert(pago);
        }


    }
}
