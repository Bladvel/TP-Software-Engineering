using Servicios.Multiidioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLIdioma
    {

        private DAL.mp_idioma mapper = new DAL.mp_idioma();


        public List<Idioma> Listar()
        {
            return mapper.Listar();
        }

    }
}
