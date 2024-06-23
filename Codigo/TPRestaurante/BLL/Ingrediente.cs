using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BLL
{
    public class Ingrediente
    {
        MP_Ingrediente mpIngrediente = new MP_Ingrediente();

        public List<BE.Ingrediente> Listar()
        {
            return mpIngrediente.GetAll();
        }

        public List<BE.Ingrediente> ListarIngredientesPorProducto(int codProducto)
        {
            return mpIngrediente.GetIngredientsByProduct(codProducto);
        }

        //public bool VerificarStock(BE.Ingrediente ingrediente, int cantidadRequerida)
        //{
        //    List<BE.Ingrediente> ingredientes = ListarIngredientes();

        //    BE.Ingrediente ingredienteBuscado = ingredientes.FirstOrDefault(i => i.CodIngrediente.Equals(ingrediente.CodIngrediente));

        //    bool disponible = ingredienteBuscado.Cantidad >= cantidadRequerida;

        //    return disponible;
        //}

        public BE.Ingrediente ObtenerIngredientePorCodigo(int codigo)
        {
            return mpIngrediente.GetById(codigo);
        }


        public void ActualizarStock(BE.Ingrediente ingrediente, int cantidad)
        {

            BE.Ingrediente i = ObtenerIngredientePorCodigo(ingrediente.CodIngrediente);
            i.Cantidad += cantidad;

            mpIngrediente.Update(i);
        }
    }
}
