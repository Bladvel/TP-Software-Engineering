using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DVV
    {
        private string tabla;

        public string Tabla
        {
            get { return tabla; }
            set { tabla = value; }
        }


        private int columna;

        public int Columna
        {
            get { return columna; }
            set { columna = value; }
        }


        private string dvv;

        public string DV
        {
            get { return dvv; }
            set { dvv = value; }
        }
    }
}
