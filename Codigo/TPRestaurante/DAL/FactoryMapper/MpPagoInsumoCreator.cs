using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpPagoInsumoCreator: IMapperCreator
    {
        private MpPagoInsumoCreator()
        {
        }
        private static MpPagoInsumoCreator _instance;

        public static MpPagoInsumoCreator GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MpPagoInsumoCreator();
            }
            return _instance;
        }


        public IMapper CreateMapper()
        {
            Access access = new Access();
            
            return new MP_PagoInsumo(access);
        }
    }
}
