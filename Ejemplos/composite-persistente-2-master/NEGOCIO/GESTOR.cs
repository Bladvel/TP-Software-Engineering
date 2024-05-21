using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using CLASES;

namespace NEGOCIO
{
    public class GESTOR
    {
        MP_PERMISO mp = new MP_PERMISO();

        public List<PERMISO> Listar()
        {
            return mp.Listar();
        }

        public void CompletarPermisos(USUARIO u)
        {
            mp.Listar(u);
        }
    }
}
