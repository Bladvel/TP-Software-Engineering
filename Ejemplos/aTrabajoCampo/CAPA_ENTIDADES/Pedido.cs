using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public class Pedido : IDVH
    {
        public int IdPedido { get; set; }

        public string numeroPedido { get; set; }    
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public EstadoPedido oEstadoPedido { get; set; }
        public Usuario oUsuario { get; set; }
        public decimal MontoTotal { get; set; }
        public List<DetallePedido> oDetallePedido { get; set; }
        public string FechaRegistro { get; set; }
        public int DVH { get; set; }

        public IDictionary<string, object> ObtenerDatosParaDVH()
        {
            return new Dictionary<string, object>
            {
                { "NombreCl", NombreCliente },
                { "ApellidoCl", ApellidoCliente },
                { "DocumentoCl", DocumentoCliente },
                { "Total", MontoTotal }
            };
        }
    }
}
