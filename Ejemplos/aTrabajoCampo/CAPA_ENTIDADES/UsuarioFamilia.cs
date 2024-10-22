using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public class UsuarioFamilia
    {

        // Permite acceder al objeto Usuario completo relacionado con esta instancia
        public Usuario oUsuario { get; set; }

        // Permite acceder al objeto Familia completo relacionado con esta instancia
        public Familia oFamilia { get; set; }

        public int DVH { get; set; }
    }
}
