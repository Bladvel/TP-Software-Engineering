using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("PEDIDO")]
    public class Pedido
    {
        private int nroPedido;

        [ColumnMapping("NRO_PEDIDO")]
        public int NroPedido
        {
            get
            {
                return nroPedido;
            }
            set
            {
                nroPedido = value;
            }
        }

        private OrderType estado;

        [ColumnMapping("ESTADO")]
        public OrderType Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }

        }

        private DateTime fecha;

        [ColumnMapping("FECHA")]
        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;
        }

        private List<ItemProducto> productos;
        public List<ItemProducto> Productos
        {
            get => productos;
            set => productos = value;

        }
        private Cliente cliente;

        [ColumnMapping("ID_CLIENTE")]
        public Cliente Cliente
        {
            get=>cliente; 
            set=>cliente=value;
        }



        private PaymentState estadoPago;

        [ColumnMapping("ESTADO_PAGO")]
        public PaymentState EstadoPago
        {
            get => estadoPago;
            set=> estadoPago=value;
        }

        public override string ToString()
        {
            return $"Nro: {NroPedido}";
        }
    }






    

}
