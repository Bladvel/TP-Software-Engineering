using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TCTD2020.ArquitecturaCapasV2.Interfaces;
using TCTD2020.ArquitecturaCapasV2.Servicios.Composite;

namespace TCTD2020.ArquitecturaCapasV2.Servicios
{
    public class Sesion
    {

        private IUsuario _user { get; set; }

        public IUsuario Usuario
        {
            get
            {
                return _user;
            }
        }


        public void Login(IUsuario usuario)
        {
            _user = usuario;
        }

        public void Logout()
        {
            _user = null;
        }




        private bool IsInRoleRecursivo(IPermiso p, Enum tipoPermiso, bool valid)
        {

            foreach (var item in p.ObtenerHijos())
            {
                if (item is Patente && ((Patente)item).Tipo.Equals(tipoPermiso))
                {
                    valid= true;
                }
                else
                {
                    valid= IsInRoleRecursivo(item, tipoPermiso, valid);
                }
            }
            return valid;
        }


        public bool IsInRole(Enum tipoPermiso)
        {
            if (_user == null) return false;

            bool valid=false;
            foreach (var p in _user.Permisos)
            {
                if (p is Patente && ((Patente)p).Tipo.Equals(tipoPermiso))
                {
                    valid = true;
                }
                else
                {
                    valid = IsInRoleRecursivo(p, tipoPermiso, valid);
                }
            }

            return valid;
        }

        public bool IsLogged()
        {
            return _user != null;
        }
    }

}
