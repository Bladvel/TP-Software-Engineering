using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class SALA
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private List<FUNCION> funciones = new List<FUNCION>();

		public List<FUNCION> Funciones
		{
			get { return funciones; }
		}

		private List<ASIENTO> asientos = new List<ASIENTO>();	

		public List<ASIENTO> Asientos
		{
			get { return asientos; }
		}



		

	}
}