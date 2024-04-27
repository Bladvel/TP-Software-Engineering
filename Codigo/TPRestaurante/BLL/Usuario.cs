using DAL;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
        MP_Usuario mp;
        public Usuario()
        {
            mp = new MP_Usuario();
        }

        public bool AgregarUsuario(BE.Usuario usuario)
        {
            int filasAfectadas = mp.Insert(usuario);
            return filasAfectadas > 0;
        }

        public BE.Usuario ObtenerUsuario(string pUsername)
        {
            BE.Usuario user = mp.GetAll().Where(u => u.Username.Equals(pUsername)).FirstOrDefault();
            return user;
        }

        public string Login (BE.Usuario pUser)
        {
            if (!SessionManager.Instance.IsLoggedIn())
            {
                var user = ObtenerUsuario(pUser.Username);
                if ((user!=null))
                {
                    if (CryptoManager.Compare(pUser.Password, user.Password))
                    {
                        SessionManager.Instance.Login(user);
                        return "Usuario valido";
                    }
                }
            }

            return "Fallo el inicio";
        }

        public string Logout()
        {
            if(!SessionManager.Instance.IsLoggedIn())
            {
                throw new Exception("No hay sesion iniciada");
            }
            else
                SessionManager.Instance.Logout();

            return "Sesion terminada";
        }
    }
}
