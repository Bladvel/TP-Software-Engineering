using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProductoBitacora
    {
        private int id;

        public int Id
        {
            get => id;
            set => id = value;
        }


        private int codProducto;

        public int CodProducto
        {
            get => codProducto;
            set => codProducto = value;
        }

        private string nombre;

        public string Nombre
        {
            get => nombre; 
            set => nombre = value;
        }
        private string descripcion;

        public string Descripcion
        {
            get => descripcion;
            set => descripcion = value;
        }


        private float precioActual;

        public float PrecioActual
        {
            get => precioActual;
            set => precioActual = value;
        }

        private DateTime fecha;

        public DateTime Fecha
        {
            get => fecha;
            set => fecha = value;
        }

        private DateTime hora;

        public DateTime Hora
        {
            get => hora;
            set => hora = value;
        }

        private bool activo;

        public bool Activo
        {
            get => activo;
            set => activo = value;
        }

        private BE.Producto producto;

        public BE.Producto Producto
        {
            get => producto;
            set => producto = value;
        }

    }
}
