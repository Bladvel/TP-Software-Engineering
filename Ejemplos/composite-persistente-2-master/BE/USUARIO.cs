using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
    public class USUARIO
    {

        public USUARIO()
        { }

        public USUARIO(int i, string n)
        {
            id = i;
            nombre = n;
        }

        private int id;

        public int Id
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


        private List<PERMISO> permisos = new List<PERMISO>();

        public List<PERMISO> Permisos
        {
            get { return permisos ; }
            
        }


    }
}
