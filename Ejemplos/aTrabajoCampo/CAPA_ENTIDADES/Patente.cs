using CAPA_ENTIDADES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public class Patente : IPermiso
    {
        public int IdPatente { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set;}

        private List<IPermiso> _hijos = new List<IPermiso>();

        public void Agregar(IPermiso permiso)
        {
            // Las patentes generalmente no deberían tener hijos,
            // pero puedes dejarlo vacío o lanzar una excepción si se llama a este método.
            throw new InvalidOperationException("Las patentes no pueden tener permisos hijos.");
        }

        public void Eliminar(IPermiso permiso)
        {
            // Similarmente, podrías lanzar una excepción aquí también.
            throw new InvalidOperationException("Las patentes no pueden tener permisos hijos.");
        }

        public IList<IPermiso> ObtenerHijos()
        {
            // Retorna una lista vacía, ya que no se usan hijos en Patente.
            return new List<IPermiso>();
        }

        public void Mostrar(int nivel)
        {
            // Mostrar la patente con la indentación correspondiente al nivel
            Console.WriteLine($"{new string('-', nivel)} {Nombre}");
        }

    }
}
