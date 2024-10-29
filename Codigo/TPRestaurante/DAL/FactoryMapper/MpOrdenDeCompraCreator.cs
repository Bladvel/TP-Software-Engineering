using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpOrdenDeCompraCreator: IMapperCreator
    {
        private MpOrdenDeCompraCreator()
        {

        }

        private static MpOrdenDeCompraCreator _instance;

        public static MpOrdenDeCompraCreator GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MpOrdenDeCompraCreator();
                }
                return _instance;
            }
        }



        public IMapper CreateMapper()
        {
            Access access = new Access();
            MP_ItemIngrediente mpItemIngrediente = new MP_ItemIngrediente(access,new MP_Ingrediente(access));
            MP_SolicitudDeCotizacion mpSolicitudDeCotizacion = new MP_SolicitudDeCotizacion(access, mpItemIngrediente);
            MP_Proveedor mpProveedor = new MP_Proveedor(access);

            return new MP_OrdenDeCompra(access, mpSolicitudDeCotizacion, mpProveedor);

        }
    }
}
