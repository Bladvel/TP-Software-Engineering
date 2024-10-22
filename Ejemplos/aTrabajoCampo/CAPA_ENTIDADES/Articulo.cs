using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public bool estado { get; set; }

        public Categoria ocategoria { get; set; }

        public DateTimeKind fechaRegistro { get; set; }
    }
}
