using CompositePersistente.BE;
using CompositePersistente.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePersistente
{
    public class BLLSesion
    {

        public void Login(Usuario u)
        {

            (new PermisosRepository()).FillUserComponents(u);
            SimuladorSesion.GetInstance.Login(u);
          
        }

        public void Logout()
        {
            SimuladorSesion.GetInstance.Logout();
        }
    }
}
