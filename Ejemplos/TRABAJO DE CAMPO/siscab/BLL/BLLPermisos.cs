using BE;
using DAL;
using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLPermisos
    {
        PermisosRepository _permisos;

        public BLLPermisos()
        {
            _permisos = new PermisosRepository();
        }

        public bool Existe(Componente c, int id)
        {
            bool existe = false;

            if (c.Id.Equals(id))
                existe = true;
            else

                foreach (var item in c.Hijos)
                {

                    existe = Existe(item, id);
                    if (existe) return true;
                }

            return existe;

        }

        public Array GetAllPermission()
        {
            return _permisos.GetAllPermission();
        }

        public Componente GuardarComponente(Componente p, bool esfamilia)
        {
            return _permisos.GuardarComponente(p, esfamilia);
        }

        public void GuardarFamilia(Familia c)
        {
            _permisos.GuardarFamilia(c);
        }

        public IList<Patente> GetAllPatentes()
        {
            return _permisos.GetAllPatentes();
        }

        public IList<Familia> GetAllFamilias()
        {
            return _permisos.GetAllFamilias();
        }

        public IList<Componente> GetAll(string familia)
        {
            return _permisos.GetAll(familia);

        }

        public void FillUserComponents(Usuario u)
        {
            _permisos.FillUserComponents(u);

        }

        public void FillFamilyComponents(Familia familia)
        {
            _permisos.FillFamilyComponents(familia);
        }

    }
}
