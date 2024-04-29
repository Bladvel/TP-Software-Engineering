using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Entity
    {
		private int id;

		public int Id
		{
			get { return id; }
			set { id = value; }
		}



	}
}
