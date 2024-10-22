using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public class FamiliaPatente
    {
        public Familia oFamilia { get; set; }
        public Patente oPatente { get; set; }

        public int DVH { get; set; }
    }
}
