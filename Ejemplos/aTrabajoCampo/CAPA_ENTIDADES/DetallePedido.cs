using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES
{
    public class DetallePedido
    {
        public int IdDetallePedido { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal SubTotal { get; set; }
        public Articulo oArticulo { get; set; }
        public Pedido oPedido { get; set; }

    }
}
