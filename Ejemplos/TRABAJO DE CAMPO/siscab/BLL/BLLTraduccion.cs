using Servicios.Multiidioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLTraduccion
    {
        private DAL.mp_traduccion mapper = new DAL.mp_traduccion();

        private DAL.mp_idioma mapperIdioma = new DAL.mp_idioma();
        private DAL.mp_etiqueta mapperEtiqueta = new DAL.mp_etiqueta();

        public List<Traduccion> Listar()
        {
            return mapper.Listar();
        }

        public List<Traduccion> ListarPorIdioma (Idioma idioma)
        {
            List<Traduccion> traduccionesIdioma = new List<Traduccion>();
            List<Traduccion> traducciones = Listar();

            for (int i = 0; i < traducciones.Count; i++)
            {
                if (traducciones[i].idioma.Id == idioma.Id)
                {
                    traduccionesIdioma.Add(traducciones[i]);
                }
            }
            return traduccionesIdioma;
        }
    }
}
