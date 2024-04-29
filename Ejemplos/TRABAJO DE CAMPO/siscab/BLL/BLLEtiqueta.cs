using Servicios.Multiidioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLEtiqueta
    {

        private DAL.mp_etiqueta mapper = new DAL.mp_etiqueta();


        public List<Etiqueta> Listar()
        {
            return mapper.Listar();
        }



    }
}
