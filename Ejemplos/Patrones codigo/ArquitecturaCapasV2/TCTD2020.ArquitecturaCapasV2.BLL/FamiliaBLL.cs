using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCTD2020.ArquitecturaCapasV1.BLL;
using TCTD2020.ArquitecturaCapasV2.DAL;
using TCTD2020.ArquitecturaCapasV2.Interfaces;
using TCTD2020.ArquitecturaCapasV2.Servicios.Composite;

namespace TCTD2020.ArquitecturaCapasV2.BLL
{
    public class FamiliaBLL : AbstractBLL<IFamilia>
    {
        PatenteBLL _bllPatentes = new PatenteBLL();
        public FamiliaBLL()
        {
            _crud = new FamiliaDAL();
        }


        public void SimularDatos()
        {

            _bllPatentes.SimularDatos();

            var f1 = new Familia();
            f1.Nombre = "Gestores de usuarios";
            var p1 = _bllPatentes.GetAll().Where(pp => pp.Nombre.Contains("Puede gestionar usuarios")).FirstOrDefault();
            if (p1 != null) f1.AgregarPermiso(p1);
            _crud.Save(f1);


            var f2= new Familia();
            var p2 = _bllPatentes.GetAll().Where(pp => pp.Nombre.Contains("Puede gestionar permisos")).FirstOrDefault();
            if (p2 != null) f2.AgregarPermiso(p2);

            f2.Nombre = "Gestores de permisos";
            _crud.Save(f2);


            var f3 = new Familia();
            f3.Nombre = "Administradores";
            f3.AgregarPermiso(f1);
            f3.AgregarPermiso(f2);
            _crud.Save(f3);
        }


    }
}
