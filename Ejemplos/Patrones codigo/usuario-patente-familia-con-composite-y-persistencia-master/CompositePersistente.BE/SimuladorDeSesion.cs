using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePersistente.BE
{
    public class SimuladorSesion
    {
        static SimuladorSesion _sesion;
        Usuario _usuario;

        public static SimuladorSesion GetInstance
        {
            get
            {
                if (_sesion == null) _sesion = new SimuladorSesion();
                return _sesion;
            }
        }
        public bool IsLoggedIn()
        {
            return _usuario != null;
        }

        bool isInRole(Componente c, TipoPermiso permiso, bool existe)
        {


            if (c.Permiso.Equals(permiso))
                existe = true;
            else
            {
                foreach (var item in c.Hijos)
                {
                    existe = isInRole(item, permiso, existe);
                    if (existe) return true;
                }



            }

            return existe;
        }

        public bool IsInRole(TipoPermiso permiso)
        {
            bool existe = false;
            foreach (var item in _usuario.Permisos)
            {
                if (item.Permiso.Equals(permiso))
                    return true;
                else
                {
                    existe = isInRole(item, permiso, existe);
                    if (existe) return true;
                }

            }

            return existe;
        }

        public void Logout()
        {
            _sesion._usuario = null;
        }


        public void Login(Usuario u)
        {
            _sesion._usuario = u;
            
        }

        private SimuladorSesion()
        {

        }
    }
}
