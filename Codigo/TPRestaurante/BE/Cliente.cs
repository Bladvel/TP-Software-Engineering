using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace BE
{
    [TableMapping("CLIENTE")]
    public class Cliente
    {
        private int id;

        [ColumnMapping("ID")]
        public int ID
        {
            get=> id; 
            set => id=value;
        }



        private string nombre;

        [ColumnMapping("NOMBRE")]
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

        [ColumnMapping("APELLIDO")]
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

        [ColumnMapping("DNI")]
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

        [ColumnMapping("TELEFONO")]
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

        [ColumnMapping("ACTIVO")]
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
