using EjemploArquitectura.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.Services
{
    
    public class Traduccion :  ITraduccion
    {
        public IEtiqueta Etiqueta { get; set; }
        public string Texto { get; set; }
    }
}
