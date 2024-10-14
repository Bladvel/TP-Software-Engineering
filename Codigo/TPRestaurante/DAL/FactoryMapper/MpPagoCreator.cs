using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpPagoCreator: IMapperCreator
    {
        private MpPagoCreator() { }
        private static MpPagoCreator instance;
        public static MpPagoCreator GetInstance()
        {
            if (instance == null)
                instance = new MpPagoCreator();
            return instance;
        }

        public IMapper CreateMapper()
        {
            Access access = new Access();
            MP_Cliente mpCliente = new MP_Cliente(access);
            MP_Producto mpProducto = new MP_Producto(access, new MP_Ingrediente(access));
            MP_ItemProducto mpItem = new MP_ItemProducto(access,mpProducto);
            MP_Pedido mpPedido = new MP_Pedido(access, mpCliente, mpItem);
            MP_MetodoDePago mpMetodo = new MP_MetodoDePago(access, new MP_PagoEfectivo(access), new MP_PagoTarjeta(access));
            return new MP_Pago(access, mpPedido, mpMetodo);
        }
    }
}
