using BE;
using DAL;
using Interfaces;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.FactoryMapper;

namespace BLL
{
    public class User
    {
        MP_User mp;
        public User()
        {
            mp = MpUserCreator.GetInstance.CreateMapper() as MP_User;
        }

        public Guid AddUser(BE.User user)
        {
            Guid id = mp.InsertWithGuid(user);
            return id;
        }

        public BE.User GetUser(string pUsername)
        {
            BE.User user = mp.GetAll().Where(u => u.Username.Equals(pUsername)).FirstOrDefault();
            return user;
        }

        public List<BE.User> ListUsers() {
            List<BE.User> usuarios = new List<BE.User>();

            usuarios = mp.GetAll();
            return usuarios;
            
        }

        public List<BE.User> ListAvailableChefs()
        {
            List<BE.User> cocineros = new List<BE.User>();

            cocineros = mp.GetAllChefs();
            return cocineros;

        }



        public LoginResult Login (BE.User pUser)
        {
            if (SessionManager.Instance.IsLoggedIn())
            {
                throw new Exception("Ya hay una sesión iniciada");
            }



            var user = GetUser(pUser.Username);
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
                AsignPermissions(user);
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

        public void UnblockUser(BE.User user)
        {
            user.Bloqueo = false;
            mp.ChangeBlockage(user);
        }

        public void AsignPermissions(BE.User user)
        {
            mp.AsignPermissions(user);
        }


        public bool VerifyUser(BE.User user, string password)
        {
            return CryptoManager.Compare(password, user.Password);


        }

        public int ChangePassword(BE.User user, string password)
        {

            var nuevaPassword = CryptoManager.Hash(password);
            user.Password = nuevaPassword;

            return mp.ChangePassword(user);
        }

        public void UpdatePermissions(BE.User user)
        {
            mp.UpdatePermissions(user);
        }

        public void UpdateAvailability(BE.User cocineroSeleccionado, AvailabilityType disponibilidad)
        {
            cocineroSeleccionado.Availability = disponibilidad;
            mp.UpdateAvailability(cocineroSeleccionado);
        }

        public void UpdateUser(BE.User selectedUser)
        {
            mp.Update(selectedUser);
        }


        public string Concatenar(BE.User user)
        {
            return user.ID + user.Username + user.Password + user.DNI + user.Nombre + user.Apellido 
                   + user.Email + user.Activo + user.Bloqueo + user.Attempts + user.Availability + user.Idioma.Id;
        }
    }
}
