using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Cliente
    {
        private int id;
        public int ID
        {
            get=> id; 
            set => id=value;
        }



        private string nombre;
        public string Nombre 
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        private string apellido;

        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }

        private int dni;

        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                dni = value;
            }
        }

        private string telefono;

        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }


        private bool activo;

        public bool Activo //borrado logico
        {
            get { return activo; }
            set { activo = value; }
        }


        public Cliente(string nombre, string apellido, int dni, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            DNI = dni;
            Activo = true;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }

        public Cliente()
        {

        }

    }
}
