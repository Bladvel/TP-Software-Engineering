using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpComandaCreator: IMapperCreator
    {
        private MpComandaCreator()
        {

        }

        private static MpComandaCreator instance;
        public static MpComandaCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpComandaCreator();
                }
                return instance;
            }
        }

        public IMapper CreateMapper()
        {
            Access access = new Access();

            MP_Cliente mpCliente = new MP_Cliente(access);
            MP_Producto mpProducto = new MP_Producto(access, new MP_Ingrediente(access));
            MP_ItemProducto mpItem = new MP_ItemProducto(access, mpProducto);

            MP_Pedido mpPedido = new MP_Pedido(access, mpCliente, mpItem);
            
            MP_User mpUser = new MP_User(access, new MP_Idioma(access), new MP_Permission(access));

            return new MP_Comanda(access, mpPedido, mpUser);



        }
    }
}
