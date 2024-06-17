using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CatalogoProductos
    {
        private MP_Producto mp = new MP_Producto();
        public List<BE.Producto> ListarProductos()
        {
            return mp.GetAll();
        }
    }
}
