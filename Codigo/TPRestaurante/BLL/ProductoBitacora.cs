using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoBitacora
    {
        DAL.MP_Producto_Bitacora mpProductoBitacora = new DAL.MP_Producto_Bitacora();
        public List<BE.ProductoBitacora> Listar()
        {
            return mpProductoBitacora.GetAll();
        }

        public List<BE.ProductoBitacora> Filtrar(DateTime fi, DateTime ff, int? codProducto, string nombre)
        {
            return mpProductoBitacora.Filter(fi, ff, nombre, codProducto);
        }


    }
}
