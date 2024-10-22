using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public interface IDVH
    {
        int DVH { get; set; }
        IDictionary<string, object> ObtenerDatosParaDVH();
    }
}
