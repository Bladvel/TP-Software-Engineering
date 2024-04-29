using BE;
using Servicios.Multiidioma;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Sesion
    {
        private Usuario _user { get; set; }

        public Usuario Usuario
        {
            get
            {
                return _user;
            }
        }

        static IList<IIdiomaObserver> _observers = new List<IIdiomaObserver>();


        public void Login (Usuario usuario)
        {
           
            _user = usuario;

        }

        public void Logout ()
        {
            _user = null;


        }

        public bool IsLogged()
        {
            return _user != null;
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
            foreach (var item in _user.Permisos)
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


        public static void SuscribirObservador(IIdiomaObserver o)
        {
            _observers.Add(o);
        }
        public static void DesuscribirObservador(IIdiomaObserver o)
        {
            _observers.Remove(o);
        }

        private static void Notificar(IIdioma idioma)
        {
            foreach (var o in _observers)
            {
                o.UpdateLanguage(idioma);
            }
        }

        //El unico de estos metodos que no es static
        public void CambiarIdioma(IIdioma idioma)
        {
            if ( _user != null)
            {
                _user.Idioma = idioma;
                Notificar(idioma);
            }
        }
    
    }
}
