using CompositePersistente.BE;
using CompositePersistente.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePersistente
{
      
    public class UsuariosBLL 
    {
        UsuariosRepository _usuarios;
        public UsuariosBLL()
        {
            _usuarios = new UsuariosRepository();
        }

        public List<Usuario> GetAll()
        {
            return _usuarios.GetAll();
        }

        public void GuardarPermisos(Usuario u)
        {
            _usuarios.GuardarPermisos(u);
        }
    }
}
