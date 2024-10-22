using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_ENTIDADES.Interfaces
{
    public interface IPermiso
    {
        string Nombre { get; set; }
        void Agregar(IPermiso permiso);
        void Eliminar(IPermiso permiso);
        IList<IPermiso> ObtenerHijos();
        void Mostrar(int nivel);
    }
}
