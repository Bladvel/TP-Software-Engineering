using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpPagoEfectivoCreator: IMapperCreator
    {
        private MpPagoEfectivoCreator() { }
        private static MpPagoEfectivoCreator instance;
        public static MpPagoEfectivoCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpPagoEfectivoCreator();
                }
                return instance;
            }
        }
        public IMapper CreateMapper()
        {
            Access access = new Access();
            return new MP_PagoEfectivo(access);
        }
    }
}
