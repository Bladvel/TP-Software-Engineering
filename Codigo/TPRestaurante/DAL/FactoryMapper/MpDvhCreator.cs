using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpDvhCreator: IMapperCreator
    {
        private MpDvhCreator(){}
        private static MpDvhCreator instance;
        public static MpDvhCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpDvhCreator();
                }
                return instance;
            }
        }
        public IMapper CreateMapper()
        {
            Access access = new Access();
            return new MP_Dvh(access);
        }
    }
}
