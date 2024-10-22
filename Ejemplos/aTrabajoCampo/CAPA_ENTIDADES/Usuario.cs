using CAPA_ENTIDADES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public class Usuario : IDVH
    {
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }

        public int Dni { get; set; }

        public string NombreUsuario { get; set; }

        public string Clave { get; set; }
        public int Contador_Sesion { get; set; }

        public bool Estado { get; set; }
        public string Fecha_Registro { get; set; }

        public int DVH { get; set; }


        private List<IPermiso> _permisos = new List<IPermiso>();
        public IDictionary<string, object> ObtenerDatosParaDVH()
        {
            return new Dictionary<string, object>
            {
                { "Nombre", Nombre },
                { "Apellido", Apellido },
                { "Dni", Dni },
                { "Email", Email },
                { "NombreUsuario", NombreUsuario },
                { "Clave", Clave }
            };
        }

        public void Agregar(IPermiso permiso)
        {
            _permisos.Add(permiso);
        }

        public void Eliminar(IPermiso permiso)
        {
            _permisos.Remove(permiso);
        }

        public IList<IPermiso> ObtenerHijos()
        {
            return _permisos.AsReadOnly();
        }

        public void Mostrar(int nivel)
        {
            Console.WriteLine($"{new string('-', nivel)} Usuario: {Nombre} {Apellido}");
            foreach (var permiso in _permisos)
            {
                permiso.Mostrar(nivel + 1); // Mostrar los permisos del usuario
            }
        }

    }

}
