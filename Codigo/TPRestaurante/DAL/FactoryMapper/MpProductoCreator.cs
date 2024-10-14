using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpProductoCreator: IMapperCreator
    {
        private MpProductoCreator(){}
        private static MpProductoCreator instance;
        public static MpProductoCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpProductoCreator();
                }
                return instance;
            }
        }
        public IMapper CreateMapper()
        {
            Access access = new Access();
            return new MP_Producto(access, new MP_Ingrediente(access));
        }
    }
}
