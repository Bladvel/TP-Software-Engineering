using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class DVH
    {
		private string modulo;

		public string Modulo
		{
			get { return modulo; }
			set { modulo = value; }
		}

		private int registro;

		public int Registro
		{
			get { return registro; }
			set { registro = value; }
		}

		private string dv;

		public string DV
		{
			get { return dv; }
			set { dv = value; }
		}

	}
}
