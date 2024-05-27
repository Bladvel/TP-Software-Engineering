using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASES
{
public class PERMISO
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public virtual bool Validar(PERMISO permiso)
        {
            return (permiso.id == this.id);
        }

    }
}
