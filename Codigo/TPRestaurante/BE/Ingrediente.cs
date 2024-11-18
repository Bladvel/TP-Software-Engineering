using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("INGREDIENTE")]
    public class Ingrediente
    {

        private int cod;

        [ColumnMapping("COD_INGREDIENTE")]
        public int CodIngrediente
        {
            get => cod; 
            set => cod=value;
        }

        private string nombre;

        [ColumnMapping("NOMBRE")]
        public string Nombre
        {
            get=>nombre; 
            set=>nombre=value;
        }

        private int cantidad;

        [ColumnMapping("CANTIDAD_ACTUAL")]
        public int Cantidad
        {
            get => cantidad;
            set => cantidad=value;
        }

        public Ingrediente(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }

        public Ingrediente()
        {
            
        }


        private float costoReferencial;

        [ColumnMapping("COSTO_REFERENCIAL")]
        public float CostoReferencial
        {
            get => costoReferencial;
            set => costoReferencial = value;
        }

        private int stockMin;

        [ColumnMapping("STOCK_MINIMO")]
        public int StockMin
        {
            get => stockMin;
            set => stockMin = value;
        }

        private int stockMax;

        [ColumnMapping("STOCK_MAXIMO")]
        public int StockMax
        {
            get => stockMax; 
            set => stockMax = value;
        }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}
