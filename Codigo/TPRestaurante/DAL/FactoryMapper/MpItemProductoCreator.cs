using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpItemProductoCreator: IMapperCreator
    {
        private MpItemProductoCreator() { }
        private static MpItemProductoCreator instance;
        public static MpItemProductoCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpItemProductoCreator();
                }
                return instance;
            }
        }
        public IMapper CreateMapper()
        {
            Access access = new Access();
            MP_Producto mpProducto = new MP_Producto(access, new MP_Ingrediente(access));
            return new MP_ItemProducto(access, mpProducto);
        }
    }
}
