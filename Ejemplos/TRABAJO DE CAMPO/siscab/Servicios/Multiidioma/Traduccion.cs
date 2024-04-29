using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Multiidioma
{
    public class Traduccion: ITraduccion
    {
        public IEtiqueta Etiqueta { get; set; }
        public string Texto { get; set; }

        //esta se la agregue yo NO ESTA EN EL EJEMPLE ARQUITECTURA
        public IIdioma idioma { get; set; }


        public override string ToString()
        {
            return Texto; 
        }

    }
}
