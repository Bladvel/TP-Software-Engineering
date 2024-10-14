using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DVH
    {
        private string tabla;

        public string Tabla
        {
            get { return tabla; }
            set { tabla = value; }
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
