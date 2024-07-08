using Interfaces;

namespace Services.Multiidioma
{
    public class Idioma: IIdioma
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Default { get; set; }
    }
}
