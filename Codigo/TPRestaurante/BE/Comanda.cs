using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("COMANDA")]
    public class Comanda
    {
        private int id;

        [ColumnMapping("ID")]
        public int ID
        {
            get => id; 
            set => id = value;
        }

        private string descripcion;

        [ColumnMapping("DESCRIPCION")]
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private Pedido pedido;

        [ColumnMapping("ID_PEDIDO")]
        public Pedido PedidoAsignado
        {
            get => pedido; 
            set => pedido=value;
        }

        private User cocinero;

        [ColumnMapping("ID_COCINERO")]
        public User Cocinero
        {
            get => cocinero;
            set => cocinero = value;
        }

        public Comanda(Pedido pedido, User cocinero, string descripcion = "")
        {
            PedidoAsignado = pedido;
            Cocinero = cocinero;
            Descripcion = descripcion;
        }


    }
}
