using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BE
{
    public class ENTRADA
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private SALA sala;	

		public SALA Sala
		{
			get { return sala; }
			set { sala = value; }
		}

		private FUNCION funcion;

		public FUNCION Funcion
		{
			get { return funcion; }
			set { funcion = value; }
		}

		private ASIENTO asiento;

		public ASIENTO Asiento
		{
			get { return asiento; }
			set { asiento = value; }
		}


	}
}