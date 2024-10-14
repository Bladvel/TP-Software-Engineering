using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpIngredienteCreator: IMapperCreator
    {

        private static MpIngredienteCreator instance;
        private MpIngredienteCreator() { }
        public static MpIngredienteCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpIngredienteCreator();
                }
                return instance;
            }
        }

        public IMapper CreateMapper()
        {
            Access access = new Access();
            return new MP_Ingrediente(access);
        }
    }
}
