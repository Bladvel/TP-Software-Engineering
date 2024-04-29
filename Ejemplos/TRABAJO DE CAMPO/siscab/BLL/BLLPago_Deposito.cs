using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPago_Deposito
    {
        DAL.mp_pago_deposito mapper = new DAL.mp_pago_deposito();

        public List<BE.Pago_Deposito> Listar()
        {
            return mapper.Listar();
        }

        public void Insertar(BE.Pago_Deposito pago)
        {
            mapper.Insertar(pago);
        }



    }
}
