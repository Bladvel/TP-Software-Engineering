using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPago_Estadia
    {
        DAL.mp_pago_estadia mapper = new DAL.mp_pago_estadia();

        public List<BE.Pago_Estadia> Listar()
        {
            return mapper.Listar();
        }


       
        public void Insertar(BE.Pago_Estadia pago)
        {
            mapper.Insertar(pago);
        }


    }
}
