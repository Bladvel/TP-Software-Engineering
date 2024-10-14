using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpUserCreator: IMapperCreator
    {
        private MpUserCreator() { }
        private static MpUserCreator instance;
        public static MpUserCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpUserCreator();
                }
                return instance;
            }
        }
        public IMapper CreateMapper()
        {
            Access access = new Access();
            return new MP_User(access, new MP_Idioma(access), new MP_Permission(access));
        }
    }
}
