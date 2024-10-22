using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpProveedorCreator: IMapperCreator
    {

        private MpProveedorCreator() { }

        private static MpProveedorCreator instance;

        public static MpProveedorCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpProveedorCreator();
                }
                return instance;
            }
        }



        public IMapper CreateMapper()
        {
            Access access = new DAL.Access();
            return new DAL.MP_Proveedor(access);
        }
    }
}
