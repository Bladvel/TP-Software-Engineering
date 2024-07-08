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
