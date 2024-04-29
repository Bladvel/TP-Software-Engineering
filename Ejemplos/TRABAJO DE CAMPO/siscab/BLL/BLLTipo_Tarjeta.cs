using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTipo_Tarjeta
    {
        private DAL.mp_tipo_tarjeta mapper = new DAL.mp_tipo_tarjeta();
        public List<BE.Tipo_Tarjeta> Listar()
        {
            return mapper.Listar();
        }

       
    }
}
