using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class USUARIO
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private int dni;

		public int DNI
		{
			get { return dni; }
			set { dni = value; }
		}

		private ESTADO estado;

		public ESTADO EstadoCivil
		{
			get { return estado; }
			set { estado = value; }
		}

        public override string ToString()
        {
			return $"ID: {id} NOMBRE: {Nombre} ESTADO_CIVIL: {EstadoCivil.Estado}";
        }


    }
}
