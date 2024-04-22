using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCTD2020.ArquitecturaCapasV2.Servicios
{
    public class SingletonSesion
    {
        private static Sesion _instancia;
        private static Object _lock = new object();

        public static Sesion Instancia
         {
            get
            {
                lock (_lock)
                {
                    if (_instancia == null)
                        _instancia = new Sesion(); 
                }

                return _instancia;
            }
        }

    }
}
