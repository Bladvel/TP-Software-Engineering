using EjemploArquitectura.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploArquitectura.Domain
{
    public class Usuario : Entity, IUsuario
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public IIdioma Idioma { get; set; }
    }
}
