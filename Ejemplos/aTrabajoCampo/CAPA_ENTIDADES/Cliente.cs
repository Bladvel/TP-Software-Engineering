using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public class Cliente : IDVH
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Correo { get; set; }

        public string Dni { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public int DVH { get; set; }

        public IDictionary<string, object> ObtenerDatosParaDVH()
        {
            return new Dictionary<string, object>
            {
                { "Nombre", Nombre },
                { "Apellido", Apellido },
                { "correo", Correo },
                { "DNI", Dni },
                { "celular", Celular },
                { "direccion", Direccion }
            };
        }
    }
}
