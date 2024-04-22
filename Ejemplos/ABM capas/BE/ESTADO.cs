using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ESTADO
    {
		private int id;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}

		private string nombre;

		public string Estado
		{
			get { return nombre; }
			set { nombre = value; }
		}

        public override string ToString()
        {
			return $"ID: {ID} ESTADO: {Estado}";
        }


    }
}
