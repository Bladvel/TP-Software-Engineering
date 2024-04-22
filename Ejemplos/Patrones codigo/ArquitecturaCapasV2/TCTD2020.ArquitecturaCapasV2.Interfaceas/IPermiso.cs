using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV2.Interfaces;

namespace TCTD2020.ArquitecturaCapasV2.Interfaces
{
    public interface IPermiso:IEntity
    {
        string Nombre { get; set; }
        void AgregarPermiso(IPermiso p);
        void QuitarPermiso(IPermiso p);
        IList<IPermiso> ObtenerHijos();
    }
    
}
