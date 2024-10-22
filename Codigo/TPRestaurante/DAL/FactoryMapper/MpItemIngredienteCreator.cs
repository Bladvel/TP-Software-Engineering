using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpItemIngredienteCreator: IMapperCreator
    {

        private MpItemIngredienteCreator() { }
        private static MpItemIngredienteCreator instance;
        public static MpItemIngredienteCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpItemIngredienteCreator();
                }
                return instance;
            }
        }



        public IMapper CreateMapper()
        {
            Access access = new Access();
            MP_Ingrediente mpIngrediente = new MP_Ingrediente(access);
            return new MP_ItemIngrediente(access, mpIngrediente);



        }
    }
}
