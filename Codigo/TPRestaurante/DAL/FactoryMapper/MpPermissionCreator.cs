using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpPermissionCreator: IMapperCreator
    {
        private MpPermissionCreator() { }
        private static MpPermissionCreator instance;
        public static MpPermissionCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpPermissionCreator();
                }
                return instance;
            }
        }
        public IMapper CreateMapper()
        {
            Access access = new Access();
            return new MP_Permission(access);
        }
    }
}
