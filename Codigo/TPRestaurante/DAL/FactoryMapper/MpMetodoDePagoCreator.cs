using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpMetodoDePagoCreator: IMapperCreator
    {
        private MpMetodoDePagoCreator() { }
        private static MpMetodoDePagoCreator instance;
        public static MpMetodoDePagoCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpMetodoDePagoCreator();
                }
                return instance;
            }
        }
        public IMapper CreateMapper()
        {
            Access access = new Access();
            MP_PagoEfectivo mpPagoEfectivo = new MP_PagoEfectivo(access);
            MP_PagoTarjeta mpPagoTarjeta = new MP_PagoTarjeta(access);
            return new MP_MetodoDePago(access, mpPagoEfectivo, mpPagoTarjeta);
        }
    }
}
