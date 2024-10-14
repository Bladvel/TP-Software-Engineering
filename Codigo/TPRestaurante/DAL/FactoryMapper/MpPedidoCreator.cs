using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpPedidoCreator: IMapperCreator
    {
        private MpPedidoCreator() { }
        private static MpPedidoCreator instance;
        public static MpPedidoCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpPedidoCreator();
                }
                return instance;
            }
        }
        public IMapper CreateMapper()
        {
            Access access = new Access();
            MP_Cliente mpCliente = new MP_Cliente(access);
            MP_Ingrediente mpIngrediente = new MP_Ingrediente(access);
            MP_Producto mpProducto = new MP_Producto(access, mpIngrediente);
            MP_ItemProducto mpItem = new MP_ItemProducto(access, mpProducto);
            return new MP_Pedido(access, mpCliente,mpItem);
        }


    }
}
