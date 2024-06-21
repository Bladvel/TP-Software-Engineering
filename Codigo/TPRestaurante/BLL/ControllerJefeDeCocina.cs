using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;
using Interfaces;

namespace BLL
{
    public class ControllerJefeDeCocina
    {
        private CatalogoIngredientes catalogoIngredientes = new CatalogoIngredientes();


        
        public (List<Ingrediente> ingredientesDisponibles, List<Ingrediente> ingredientesFaltantes) VerificarDisponibilidad(BE.Pedido pedido)
        {

            Dictionary<int, int> ingredientesRequeridos = new Dictionary<int, int>();
            List<Ingrediente> ingredientesDisponibles = new List<Ingrediente>();
            List<Ingrediente> ingredientesFaltantes = new List<Ingrediente>();

            
            foreach (ItemProducto item in pedido.Productos)
            {
                
                foreach (Ingrediente ingrediente in item.Producto.Ingredientes)
                {
                    
                    if (ingredientesRequeridos.ContainsKey(ingrediente.CodIngrediente))
                    {
                        ingredientesRequeridos[ingrediente.CodIngrediente] += item.Cantidad;
                    }
                    else
                    {
                        ingredientesRequeridos[ingrediente.CodIngrediente] = item.Cantidad;
                    }
                }


            }

            foreach (var requerido in ingredientesRequeridos)
            {
                int codIngrediente = requerido.Key;
                int cantidadRequerida = requerido.Value;

                
                Ingrediente ingredienteDisponible = catalogoIngredientes.ObtenerIngredientePorCodigo(codIngrediente);

                if (ingredienteDisponible != null && ingredienteDisponible.Cantidad >= cantidadRequerida)
                {
                    
                    ingredientesDisponibles.Add(ingredienteDisponible);
                }
                else
                {
                   
                    Ingrediente ingredienteFaltante = new Ingrediente
                    {
                        CodIngrediente = codIngrediente,
                        Nombre = ingredienteDisponible.Nombre,
                        Cantidad = cantidadRequerida - (ingredienteDisponible.Cantidad) //Cantidad faltante
                    };
                    ingredientesFaltantes.Add(ingredienteFaltante);
                }
            }

            return (ingredientesDisponibles, ingredientesFaltantes);

        }

        BLL.Pedido bllPedido = new BLL.Pedido();

        public void AceptarPedido(BE.Pedido pedido)
        {
            foreach (var itemProducto in pedido.Productos)
            {
                foreach (var ingrediente in itemProducto.Producto.Ingredientes)
                {

                    catalogoIngredientes.ActualizarStock(ingrediente, -itemProducto.Cantidad);

                }
            }

            bllPedido.CambiarEstado(pedido, OrderType.Aceptado);
            
        }

        public void RechazarPedido(BE.Pedido pedido)
        {
            bllPedido.CambiarEstado(pedido, OrderType.Rechazado);
        }
    }
}
