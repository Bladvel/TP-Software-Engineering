using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Services.Multiidioma;

namespace BLL
{
    public class EtiquetaBLL
    {
        MP_Etiqueta mpEtiqueta = new MP_Etiqueta();

        public List<Etiqueta> Listar()
        {
            return mpEtiqueta.GetAll();
        }
    }
}
