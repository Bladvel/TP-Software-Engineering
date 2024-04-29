using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Usuario : EntityServicio
    {

        public Usuario()
        {
            _permisos = new List<Componente>();
        }

        List<Componente> _permisos;
        public List<Componente> Permisos
        {
            get
            {
                return _permisos;
            }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private int dni;

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        private string rol;

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }

        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        private int borrado;

        public int Borrado
        {
            get { return borrado; }
            set { borrado = value; }
        }

        private int bloqueo;

        public int Bloqueo
        {
            get { return bloqueo; }
            set { bloqueo = value; }
        }

        private int intentos;

        public int Intentos
        {
            get { return intentos; }
            set { intentos = value; }
        }

        private IIdioma idioma;

        public IIdioma Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }



        public override string ToString()
        {
            return username;
        }


    }
}
