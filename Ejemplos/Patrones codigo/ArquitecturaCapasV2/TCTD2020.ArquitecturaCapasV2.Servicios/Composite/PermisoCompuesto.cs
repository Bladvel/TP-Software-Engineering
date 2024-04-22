using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV2.Interfaces;

namespace TCTD2020.ArquitecturaCapasV2.Servicios.Composite
{
    public abstract class PermisoCompuesto : ServiceEntity,IPermiso
    {
        public string Nombre { get; set; }


       public abstract void AgregarPermiso(IPermiso p);
        public abstract void QuitarPermiso(IPermiso p);
        public abstract IList<IPermiso> ObtenerHijos();

        public override string ToString()
        {
            return this.Nombre;
        }
    
    }
}
