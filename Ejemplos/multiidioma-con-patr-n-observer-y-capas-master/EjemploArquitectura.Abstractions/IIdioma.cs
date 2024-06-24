using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.Abstractions
{
    public interface IIdioma : IEntity
    {
         string Nombre { get; set; }
        bool Default { get; set; }
    }
}
