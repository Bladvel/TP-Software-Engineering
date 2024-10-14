using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpEtiquetaCreator: IMapperCreator
    {
        private MpEtiquetaCreator(){}
        private static MpEtiquetaCreator instance;
        public static MpEtiquetaCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpEtiquetaCreator();
                }
                return instance;
            }
        }
        public IMapper CreateMapper()
        {
            Access access = new Access();
            return new MP_Etiqueta(access);
        }
    }
}
