using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpFacturaCreator: IMapperCreator
    {

        private MpFacturaCreator()
        {

        }

        private static MpFacturaCreator _instance;
        public static MpFacturaCreator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MpFacturaCreator();
            }
            return _instance;
        }


        public IMapper CreateMapper()
        {
            Access access = new Access();
            MP_ItemIngrediente mpItemIngrediente = new MP_ItemIngrediente(access, new MP_Ingrediente(access));
            MP_SolicitudDeCotizacion mpSolicitud = new MP_SolicitudDeCotizacion(access, mpItemIngrediente);

            MP_OrdenDeCompra mpOrdenDeCompra = new MP_OrdenDeCompra(access, mpSolicitud, new MP_Proveedor(access));

            return new MP_Factura(access, mpOrdenDeCompra, new MP_PagoInsumo(access));
        }
    }
}
