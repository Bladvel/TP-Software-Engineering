using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace DAL.FactoryMapper
{
    public class MpProductoBitacoraCreator: IMapperCreator
    {
        private MpProductoBitacoraCreator() { }
        private static MpProductoBitacoraCreator instance;
        public static MpProductoBitacoraCreator GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MpProductoBitacoraCreator();
                }
                return instance;
            }
        }
        public IMapper CreateMapper()
        {
            Access access = new Access();
            MP_Producto mpProducto = new MP_Producto(access, new MP_Ingrediente(access));
            return new MP_Producto_Bitacora(access, mpProducto);
        }
    }
}
