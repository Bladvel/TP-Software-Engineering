using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios
{
    public class Bitacora : EntityServicio
    {
		private DateTime fecha;

		public DateTime Fecha
		{
			get { return fecha; }
			set { fecha = value; }
		}


		private Usuario usuario;

		public Usuario Usuario
		{
			get { return usuario; }
			set { usuario = value; }
		}

		private EnumModulo modulo;

		public EnumModulo Modulo
		{
			get { return modulo; }
			set { modulo = value; }
		}

		private EnumOperacion operacion;

		public EnumOperacion Operacion
		{
			get { return operacion; }
			set { operacion = value; }
		}
		
		private int criticidad;

		public int Criticidad
		{
			get { return criticidad; }
			set { criticidad = value; }
		}


	}
}
