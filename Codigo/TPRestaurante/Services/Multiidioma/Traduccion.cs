﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Services.Multiidioma
{
    public class Traduccion: ITraduccion
    {
        public IEtiqueta Etiqueta { get; set; }
        public IIdioma idioma { get; set; }
        public string Texto { get; set; }
    }
}
