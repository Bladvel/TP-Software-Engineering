﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Producto
    {
        private int cod;

        public int CodProducto
        {
            get => cod; 
            set=>cod=value;
        }

        private string descripcion;

        public string Descripcion
        {
            get=> descripcion; 
            set=> descripcion=value;
        }

        private string nombre;

        public string Nombre
        {
            get=> nombre; 
            set=> nombre=value;
        }


        private float precio;

        public float PrecioActual
        {
            get=>precio; 
            set=>precio=value;
        }

        private List<Ingrediente> ingredientList;

        public List<Ingrediente> Ingredientes
        {
            get=> ingredientList;
            set=> ingredientList=value;
        }


        public override string ToString()
        {
            return $"{Nombre}";
        }
    }

}
