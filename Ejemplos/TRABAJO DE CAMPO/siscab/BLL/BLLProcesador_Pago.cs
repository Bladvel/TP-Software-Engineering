using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLProcesador_Pago
    {
        private mp_procesador_pago mapper = new mp_procesador_pago();

        public List<BE.Procesador_Pago> Listar()
        {
            return mapper.Listar();
        }

    }
}
