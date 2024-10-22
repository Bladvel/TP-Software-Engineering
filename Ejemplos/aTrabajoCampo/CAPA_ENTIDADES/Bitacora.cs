using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public class Bitacora : IDVH
    {
        public int IdBitacora { get; set; }
        public string Fecha_Y_Hora { get; set; }

        public Criticidad oCriticidad { get; set; }

        public Usuario oUsuario { get; set; }
        public string descripcion { get; set; }
        public int DVH { get; set; }

        public IDictionary<string, object> ObtenerDatosParaDVH()
        {
            return new Dictionary<string, object>
            {
                { "IdBitacora", IdBitacora },
                { "cod_criticidad", oCriticidad.IdCriticidad }, 
                { "cod_usuario", oUsuario.IdUsuario },          
                { "Descripcion", descripcion }

            };
        }
    }
}
