using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLSesion
    {

       public void LoginCargarPermisos(Usuario u)
        {
            (new DAL.PermisosRepository()).FillUserComponents(u);
            //SingletonSesion.Instancia.Login(u);
        }

    }
}
