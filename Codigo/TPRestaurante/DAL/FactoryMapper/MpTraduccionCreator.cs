using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpTraduccionCreator: IMapperCreator
    {
        private MpTraduccionCreator() { }
        private static MpTraduccionCreator instance;
        public static MpTraduccionCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpTraduccionCreator();
                }
                return instance;
            }
        }
        public IMapper CreateMapper()
        {
            Access access = new Access();
            return new MP_Traduccion(access);
        }
    }
}
