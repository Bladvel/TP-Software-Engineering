using EjemploArquitectura.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.Services
{
    public class Idioma : ServiceEntity,IIdioma
    {
        public string Nombre { get; set; }
        public bool Default { get; set; }
    }
}
