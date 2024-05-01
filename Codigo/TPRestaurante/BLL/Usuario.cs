using BE;
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

        public List<BE.Usuario> ListarUsuarios() {
            List<BE.Usuario> usuarios = new List<BE.Usuario>();

            usuarios = mp.GetAll();
            return usuarios;
            
        }

        public LoginResult Login (BE.Usuario pUser)
        {
            if (SessionManager.Instance.IsLoggedIn())
            {
                throw new Exception("Ya hay una sesión iniciada");
            }



            var user = ObtenerUsuario(pUser.Username);
            if ((user == null))
            {

                throw new LoginException(LoginResult.InvalidUsername);
            }
            else
            {
                if (user.Bloqueo)
                {
                    throw new LoginException(LoginResult.AlreadyBlockedUser);
                }
            }
            if (CryptoManager.Compare(pUser.Password, user.Password))
            {
                SessionManager.Instance.Login(user);
                user.Attempts = 0;
                user.DNI = CryptoManager.Encrypt(user.DNI); //Debo encriptar de nuevo el dni para no sobreescribirlo
                mp.Update(user);
                return LoginResult.ValidUser;
            }
            else
            {
                user.Attempts++;
                user.DNI = CryptoManager.Encrypt(user.DNI); //Debo encriptar de nuevo el dni para no sobreescribirlo
                mp.Update(user);
                if(user.Attempts >= 3)
                {
                    user.Bloqueo = true;
                    mp.ChangeBlockage(user);
                    throw new LoginException(LoginResult.BlockedUser);
                }else
                    throw new LoginException(LoginResult.InvalidPassword);
            }
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

        public void DesbloquearUsuario(BE.Usuario user)
        {
            user.Bloqueo = false;
            mp.ChangeBlockage(user);
        }
    }
}
