using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePersistente.BE
{
    public class Usuario
    {
        public Usuario()
        {
            _permisos = new List<Componente>();
        }

        List<Componente> _permisos;
        public int Id { get; set; }
        public string Nombre { get; set; }

        public List<Componente> Permisos
        {
            get
            {
                return _permisos;
            }
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
