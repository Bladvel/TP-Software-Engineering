using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Multiidioma
{
    public class Idioma : EntityServicio,IIdioma
    {
        public string Nombre { get; set; }
        public bool Default { get; set; }


        public override string ToString()
        {
            return Nombre; 
        }


    }
}
