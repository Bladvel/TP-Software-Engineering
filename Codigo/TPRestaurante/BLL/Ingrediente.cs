using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DAL.FactoryMapper;

namespace BLL
{
    public class Ingrediente
    {
        MP_Ingrediente mpIngrediente = MpIngredienteCreator.GetInstance.CreateMapper() as MP_Ingrediente;

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

        public void ActualizarStock(List<BE.ItemIngrediente> items)
        {
            foreach (var itemIngrediente in items)
            {
                ActualizarStock(itemIngrediente.Ingrediente, itemIngrediente.CantidadRequerida);
            }
        }




        //A probar
        public List<BE.Ingrediente> FiltrarFaltantes(List<BE.Ingrediente> ingredientes)
        {
            List<BE.Ingrediente> faltantes = new List<BE.Ingrediente>();

            foreach (var ingrediente in ingredientes)
            {
                if (ingrediente.Cantidad < ingrediente.StockMin)
                {
                    faltantes.Add(ingrediente);
                }
            }

            return faltantes;
        }

        public string Concatenar(BE.Ingrediente ingrediente)
        {
            return ingrediente.CodIngrediente + ingrediente.Nombre + ingrediente.Cantidad + ingrediente.CostoReferencial + ingrediente.StockMin + ingrediente.StockMax;
        }


    }
}
