using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Services.Multiidioma;

namespace BLL
{
    public class IdiomaBLL
    {
        MP_Idioma mpIdioma = new MP_Idioma();

        public int Insertar(Idioma idioma)
        {
            return mpIdioma.Insert(idioma);
        }
    }
}
