using EjemploArquitectura.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.Services.Multiidioma
{
   public interface IIdiomaObserver
    {
        void UpdateLanguage(IIdioma idioma);
    }
}
