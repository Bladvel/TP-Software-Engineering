using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class BLLUsuario
    {
        private DAL.mp_usuario mapper = new DAL.mp_usuario();

        private int MaxIntentos = 3;
        
        public List<Servicios.Usuario> ListarTotal()
        {
            return mapper.ListarTotal();
        }
        
        public List<Servicios.Usuario> ListarActivos()
        {
            return mapper.ListarActivos();
        }
     
        public List<Servicios.Usuario> ListarBloqueados()
        {
            return mapper.ListarBloqueados();
        }

        public List<Servicios.Usuario> ListarBorrados()
        {
            return mapper.ListarBorrados();
        }

        public void Desbloquear(Servicios.Usuario usuario)
        {
            usuario.Intentos = 0;
            usuario.Bloqueo = 0;
            Grabar(usuario);
        }

        public void Grabar (Servicios.Usuario usuario)
        {
        if(usuario.Id == 0)
            {
                mapper.Insertar(usuario);
            }
            else
            {
                mapper.Modificar(usuario);
            }
        
        }

        public void ModificarContraseña(Servicios.Usuario usuario)
        {
            mapper.ModificarContraseña(usuario);
        }

        public void VerificarBloqueo (Servicios.Usuario usuario)
        {
            usuario.Intentos++;
            if (MaxIntentos == usuario.Intentos)
            {
                usuario.Bloqueo = 1;
                Grabar(usuario);
            }
            else
            {
                Grabar(usuario);
            }           
        }

        public void ReiniciarIntentos(Servicios.Usuario usuario)
        {
            usuario.Intentos = 0;
            Grabar(usuario);
        }

        public Servicios.Usuario LoginUsuario(string user)
        {
            return mapper.BuscarUsuario(user);
        }
        public void Logout()
        {         
             SingletonSesion.Instancia.Logout();        
        }

        public bool VerificarUsuarioExistente(int dni)
        {
            bool ok = false;
            List<Servicios.Usuario> usuariosExistentes = new List<Servicios.Usuario>();
            usuariosExistentes = mapper.ListarTotal();
            for (int i = 0; i < usuariosExistentes.Count; i++)
            {
                if (usuariosExistentes[i].Dni == dni)
                {
                    ok = true;
                }
            }
            return ok;
        }

       
        public void GuardarPermisos(Servicios.Usuario u)
        {
            mapper.GuardarPermisos(u);
        }
      
    }
}
