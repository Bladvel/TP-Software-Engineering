using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpClienteCreator: IMapperCreator
    {
        private MpClienteCreator()
        {

        }

        private static MpClienteCreator _instance;
        public static MpClienteCreator GetInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new MpClienteCreator();
                }
                return _instance;
            }
        }


        public IMapper CreateMapper()
        {
            Access access = new Access();
            return new MP_Cliente(access);
        }
    }
}
