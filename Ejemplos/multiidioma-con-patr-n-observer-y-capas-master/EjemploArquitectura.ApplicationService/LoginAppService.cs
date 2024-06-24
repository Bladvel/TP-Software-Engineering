using EjemploArquitectura.Abstractions;
using EjemploArquitectura.Domain;
using EjemploArquitectura.Repository;
using EjemploArquitectura.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.ApplicationService
{
    public class LoginAppService
    {

        private UsuarioRepository _repo;
        private IdiomaAppService _idiomas;

        public LoginAppService()
        {
            _repo = new UsuarioRepository();
            _idiomas = new IdiomaAppService();
        }

      
        public void Logout()
        {
            ManejadorDeSesion.Logout();
        }

        public IDictionary<string,ITraduccion> Login(string username, string password)
        {

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) throw new Exception("Debe completar todos los campos");
            try
            {
                Usuario usuario = _repo.ObtenerUsuarioPorUsernamePassword(username, password);
                if (usuario==null) throw new Exception("Usuario o contraseña incorrecta");
                ManejadorDeSesion.Login(usuario);

                return Traductor.ObtenerTraducciones(usuario.Idioma);

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
               
            }

        }


    }
}
