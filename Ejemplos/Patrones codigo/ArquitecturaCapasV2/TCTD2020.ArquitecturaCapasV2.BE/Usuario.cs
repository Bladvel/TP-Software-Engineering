using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TCTD2020.ArquitecturaCapasV2.Interfaces;

namespace TCTD2020.ArquitecturaCapasV2.BE
{
   public class Usuario : Entity,IUsuario
    {

        private IList<IPermiso> _permisos;

        public Usuario()
        {
            _permisos = new List<IPermiso>();
        }
        public string Email { get; set; }
        public string Password { get; set; }


        public IList<IPermiso> Permisos
        {
            get
            {
                return _permisos;
            }
          
        }
       
    }
}
