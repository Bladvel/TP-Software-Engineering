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

        public int Insertar(BE.Producto producto)
        {
            return mp.Insert(producto);
        }

        public string Modificar(BE.Producto selectedProduct)
        {
            string result;

            if(mp.Update(selectedProduct) != -1)
            {
                result = "Producto modificado con éxito";
            }
            else
            {
                result = "Error al modificar producto";
            }
            return result;


        }

        public string Eliminar(BE.Producto selectedProduct)
        {
            string result;

            if(mp.Delete(selectedProduct) != -1)
            {
                result = "Producto eliminado con éxito";
            }
            else
            {
                result = "Error al eliminar producto";
            }

            return result;


        }
    }
}
