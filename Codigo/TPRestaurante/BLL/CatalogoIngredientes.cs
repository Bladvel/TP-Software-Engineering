using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class CatalogoIngredientes
    {
        MP_Ingrediente mpIngrediente = new MP_Ingrediente();

        public List<BE.Ingrediente> ListarIngredientes()
        {
            return mpIngrediente.GetAll();
        }

        public List<BE.Ingrediente> ListarIngredientesPorProducto(int codProducto)
        {
            return mpIngrediente.GetIngredientsByProduct(codProducto);
        }
    }
}
