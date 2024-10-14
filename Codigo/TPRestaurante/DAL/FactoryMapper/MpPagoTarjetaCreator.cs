using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpPagoTarjetaCreator: IMapperCreator
    {
        private MpPagoTarjetaCreator() { }
        private static MpPagoTarjetaCreator instance;
        public static MpPagoTarjetaCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpPagoTarjetaCreator();
                }
                return instance;
            }
        }
        public IMapper CreateMapper()
        {
            Access access = new Access();
            return new MP_PagoTarjeta(access);
        }
    }
}
