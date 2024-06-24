using EjemploArquitectura.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.Services
{
    public class Etiqueta : ServiceEntity, IEtiqueta
    {
        public string Nombre { get; set; }
    }
}
