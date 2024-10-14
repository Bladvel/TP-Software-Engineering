using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpIdiomaCreator: IMapperCreator
    {

        private MpIdiomaCreator()
        {
        }

        private static MpIdiomaCreator instance;
        public static MpIdiomaCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpIdiomaCreator();
                }
                return instance;
            }
        }

        public IMapper CreateMapper()
        {
            Access access = new Access();
            return new MP_Idioma(access);
        }
    }
}
