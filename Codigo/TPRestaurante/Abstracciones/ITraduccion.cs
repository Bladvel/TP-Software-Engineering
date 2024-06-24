using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ITraduccion
    {
        IEtiqueta Etiqueta { get; set; }
        IIdioma idioma { get; set; }
        string Texto { get; set; }
    }
}
