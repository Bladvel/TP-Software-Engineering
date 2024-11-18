using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using DAL.FactoryMapper;
using Interfaces;
using Services;

namespace BLL
{
    public class Ingrediente
    {
        MP_Ingrediente mpIngrediente = MpIngredienteCreator.GetInstance.CreateMapper() as MP_Ingrediente;
        BLL.Bitacora bllBitacora = new BLL.Bitacora();
        //BLL.DVH bllDvh = new DVH();
        public List<BE.Ingrediente> Listar()
        {
            return mpIngrediente.GetAll();
        }

        //public List<BE.Ingrediente> ListarIngredientesPorProducto(int codProducto)
        //{
        //    return mpIngrediente.GetIngredientsByProduct(codProducto);
        //}

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

            int resultado = mpIngrediente.Update(i);


            if(resultado != -1)
            {
                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Ingrediente,
                    Operacion = TipoOperacion.Modificacion,
                    Criticidad = 3
                };

                bllBitacora.Insertar(logEntry);
                DVH.Recalcular(DVH.Listar(), Listar(), Concatenar, ing => ing.CodIngrediente, "INGREDIENTE");
                DVV.Recalcular(Listar().Cast<object>().ToList(), typeof(BE.Ingrediente));
            }

        }

        public void ActualizarStock(List<BE.ItemIngrediente> items)
        {
            foreach (var itemIngrediente in items)
            {
                ActualizarStock(itemIngrediente.Ingrediente, itemIngrediente.CantidadRequerida);
            }

            var logUser = SessionManager.Instance.User;
            var logEntry = new Services.Bitacora
            {
                Usuario = logUser,
                Fecha = DateTime.Now,
                Modulo = TipoModulo.Ingrediente,
                Operacion = TipoOperacion.ActualizarStock,
                Criticidad = 4
            };

            bllBitacora.Insertar(logEntry);



        }



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
