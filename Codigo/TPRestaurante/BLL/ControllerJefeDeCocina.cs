﻿using System;
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
        private Ingrediente ingrediente = new Ingrediente();


        
        public (List<BE.Ingrediente> ingredientesDisponibles, List<BE.Ingrediente> ingredientesFaltantes) VerificarDisponibilidad(BE.Pedido pedido)
        {

            Dictionary<int, int> ingredientesRequeridos = new Dictionary<int, int>();
            List<BE.Ingrediente> ingredientesDisponibles = new List<BE.Ingrediente>();
            List<BE.Ingrediente> ingredientesFaltantes = new List<BE.Ingrediente>();

            
            foreach (BE.ItemProducto item in pedido.Productos)
            {
                
                foreach (BE.Ingrediente ingrediente in item.Producto.Ingredientes)
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

                
                BE.Ingrediente ingredienteDisponible = ingrediente.ObtenerIngredientePorCodigo(codIngrediente);

                if (ingredienteDisponible != null && ingredienteDisponible.Cantidad >= cantidadRequerida)
                {
                    
                    ingredientesDisponibles.Add(ingredienteDisponible);
                }
                else
                {
                   
                    BE.Ingrediente ingredienteFaltante = new BE.Ingrediente
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

                    this.ingrediente.ActualizarStock(ingrediente, -itemProducto.Cantidad);

                }
            }

            bllPedido.CambiarEstado(pedido, OrderType.Aceptado);
            
        }

        public void RechazarPedido(BE.Pedido pedido)
        {
            bllPedido.CambiarEstado(pedido, OrderType.Rechazado);
        }

        private BLL.User bllUser = new BLL.User();

        private Comanda bllComanda = new Comanda();
        public BE.Comanda GenerarComanda(BE.Pedido pedidoSeleccionado, BE.User cocineroSeleccionado, string instrucciones)
        {
            BE.Comanda nuevaComanda = new BE.Comanda(pedidoSeleccionado, cocineroSeleccionado, instrucciones);
            nuevaComanda.ID = bllComanda.Insertar(nuevaComanda);
            if (nuevaComanda.ID > 0)
            {

                bllUser.UpdateAvailability(cocineroSeleccionado, AvailabilityType.NoDisponible);
                bllPedido.CambiarEstado(pedidoSeleccionado,OrderType.EnPreparacion);
                return nuevaComanda;
            }




            return null;

        }
    }
}
