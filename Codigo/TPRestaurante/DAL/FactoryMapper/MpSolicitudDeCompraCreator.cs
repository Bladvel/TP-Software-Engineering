using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpSolicitudDeCompraCreator: IMapperCreator
    {
        private MpSolicitudDeCompraCreator() { }

        private static MpSolicitudDeCompraCreator instance;
        public static MpSolicitudDeCompraCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpSolicitudDeCompraCreator();
                }
                return instance;
            }
        }

        public IMapper CreateMapper()
        {
            Access access = new Access();
            MP_Ingrediente mpIngrediente = new MP_Ingrediente(access);
            MP_ItemIngrediente mpItemIngrediente = new MP_ItemIngrediente(access, mpIngrediente);
            return new MP_SolicitudDeCompra(access, mpItemIngrediente);

        }
    }
}
