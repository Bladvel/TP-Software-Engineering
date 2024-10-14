using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpDvvCreator: IMapperCreator
    {

        private MpDvvCreator(){}
        private static MpDvvCreator instance;
        public static MpDvvCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpDvvCreator();
                }
                return instance;
            }
        }


        public IMapper CreateMapper()
        {
            Access access = new Access();
            return new MP_Dvv(access);
        }
    }
}
