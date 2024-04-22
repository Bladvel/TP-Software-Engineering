using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV2.Interfaces;

namespace TCTD2020.ArquitecturaCapasV2.Servicios.Composite
{
   public class Patente : PermisoCompuesto,  IPatente
    {
        public Enum Tipo { get; set; }

        public override void AgregarPermiso(IPermiso p)
        {
          
        }

        public override IList<IPermiso> ObtenerHijos()
        {
            return new List<IPermiso>();
        }

        public override void QuitarPermiso(IPermiso p)
        {
            
        }
    }
}
