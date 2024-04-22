using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV2.BE;
using TCTD2020.ArquitecturaCapasV2.DAL;
using TCTD2020.ArquitecturaCapasV2.Servicios;

namespace TCTD2020.ArquitecturaCapasV2.BLL
{
    public class UsuarioBLL : AbstractBLL<Usuario>
    {
        FamiliaBLL _bllFamilias = new FamiliaBLL();
        public UsuarioBLL()
        {
            _crud = new UsuarioDAL();
           SimularDatos();
        }

        
        private void SimularDatos()
        {


            _bllFamilias.SimularDatos();

            //u1 puede gestionar usuarios
            var u = new Usuario();
            u.Email = "u1@mail.com";
            u.Password = Encriptador.Hash("123");
            var f = _bllFamilias.GetAll().Where(ff => ff.Nombre.Contains("Gestores de usuarios")).FirstOrDefault();
            if (f != null) u.Permisos.Add(f);

            _crud.Save(u);


            //u2 puede gestionar permisos
            u = new Usuario();
            u.Email = "u2@mail.com";
            u.Password = Encriptador.Hash("123");
            f = _bllFamilias.GetAll().Where(ff => ff.Nombre.Contains("Gestores de permisos")).FirstOrDefault();
            if (f != null) u.Permisos.Add(f);
            _crud.Save(u);
            

            //admin tiene todo
            u = new Usuario();
            u.Email = "admin@mail.com";
            u.Password = Encriptador.Hash("123");
            f = _bllFamilias.GetAll().Where(ff => ff.Nombre.Contains("Administradores")).FirstOrDefault() ;
            if (f != null) u.Permisos.Add(f);
       
            _crud.Save(u);




        }

        public LoginResult Login(string email, string password)
        {

            if (SingletonSesion.Instancia.IsLogged())
                throw new Exception("Ya hay una sesión iniciada"); //doble validación, anulo en boton en formulario y valido en la bll


            var user = _crud.GetAll().Where(u => u.Email.Equals(email)).FirstOrDefault();
            if (user == null) throw new LoginException(LoginResult.InvalidUsername);

            if (!Encriptador.Hash(password).Equals(user.Password))
                throw new LoginException(LoginResult.InvalidPassword);
            else
            {
                SingletonSesion.Instancia.Login(user);
                 return LoginResult.ValidUser;
            }

           
        }

        public void Logout()
        {
              if (!SingletonSesion.Instancia.IsLogged())
                throw new Exception("No hay sesión iniciada"); //doble validación, anulo en boton en formulario y valido en la bll


            SingletonSesion.Instancia.Logout();
        }
    }
}
