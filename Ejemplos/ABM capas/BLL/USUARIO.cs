using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class USUARIO
    {
        MP_USUARIO mp = new MP_USUARIO();
        public int Grabar(BE.USUARIO uSUARIO)
        {
            int filasAfectadas = mp.Insertar(uSUARIO);
            return filasAfectadas;
        }

        public List<BE.USUARIO> ObtenerUsuarios()
        {
            List<BE.USUARIO> usuarios = mp.GetList();
            return usuarios;
        }
    }
}
