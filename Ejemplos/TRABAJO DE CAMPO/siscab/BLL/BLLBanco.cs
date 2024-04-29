using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLBanco
    {
        private DAL.mp_banco mapper = new DAL.mp_banco();
        public List<BE.Banco> Listar()
        {
            return mapper.Listar();
        }


    }
}
