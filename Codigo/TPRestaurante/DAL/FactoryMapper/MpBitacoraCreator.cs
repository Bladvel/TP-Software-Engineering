using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpBitacoraCreator: IMapperCreator
    {

        private MpBitacoraCreator(){}

        private static MpBitacoraCreator instance;

        public static MpBitacoraCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpBitacoraCreator();
                }
                return instance;
            }
        }

        public IMapper CreateMapper()
        {
            Access access = new Access();
            MP_Idioma mpIdioma = new MP_Idioma(access);
            MP_Permission mpPermission = new MP_Permission(access);
            MP_User mpUser = new MP_User(access, mpIdioma, mpPermission );
            return new MP_Bitacora(access, mpUser);
        }




    }
}
