using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Producto
    {
        private MP_Producto mp = new MP_Producto();
        public List<BE.Producto> Listar()
        {
            return mp.GetAll();
        }

        public int Actualizar(BE.Producto producto)
        {
            return mp.Update(producto);
        }
    }
}
