using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;

namespace BLL
{
    public class Proveedor
    {

        MP_Proveedor mp = MpProveedorCreator.GetInstance.CreateMapper() as MP_Proveedor;


        public List<BE.Proveedor> Listar()
        {
            return mp.GetAll();
        }


    }
}
