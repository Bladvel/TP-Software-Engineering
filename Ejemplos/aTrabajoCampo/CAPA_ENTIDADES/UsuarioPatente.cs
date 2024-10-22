using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public class UsuarioPatente
    {

        public int IdUsuario { get; set; }
        public int IdPatente { get; set; }

        // Propiedades de navegación (opcional)
        public Usuario Usuario { get; set; }
        public Patente Patente { get; set; }

        public int DVH { get; set; }


    }
}
