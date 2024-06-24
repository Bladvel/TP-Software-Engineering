using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Services.Multiidioma
{
    public interface IIdiomaObserver
    {
        void UpdateLanguage(IIdioma idioma);
    }
}
