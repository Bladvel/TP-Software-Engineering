using CAPA_ENTIDADES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public class Familia : IPermiso
    {
        public int IdFamiliia { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        private List<IPermiso> _hijos = new List<IPermiso>();

        public void Agregar(IPermiso permiso)
        {
            _hijos.Add(permiso);
        }

        public void Eliminar(IPermiso permiso)
        {
            _hijos.Remove(permiso);
        }

        public IList<IPermiso> ObtenerHijos()
        {
            return _hijos.AsReadOnly();
        }

        public void Mostrar(int nivel)
        {
            // Mostrar la familia con la indentación correspondiente al nivel
            Console.WriteLine($"{new string('-', nivel)} {Nombre}");
            foreach(var hijo in _hijos)
            {
                hijo.Mostrar(nivel + 1);
            }
        }
    }
}
