using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV2.Interfaces;

namespace TCTD2020.ArquitecturaCapasV2.Servicios.Composite
{
    public class Familia : PermisoCompuesto, IFamilia
    {
        private IList<IPermiso> _hijos;
        public Familia()
        {
            _hijos = new List<IPermiso>();
        }
        public override void AgregarPermiso(IPermiso p)
        {
            if (!_hijos.Contains(p))
                _hijos.Add(p);
        }

        public override IList<IPermiso> ObtenerHijos()
        {
            return _hijos.ToArray();
        }

        public override void QuitarPermiso(IPermiso p)
        {
            if (_hijos.Contains(p))
                _hijos.Remove(p);
        }
    }
}
