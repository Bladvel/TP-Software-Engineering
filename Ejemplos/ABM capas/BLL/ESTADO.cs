using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ESTADO
    {

        MP_ESTADO mp = new MP_ESTADO();

        public int Grabar(BE.ESTADO estado)
        {
            int filasAfectadas;
            if(estado.ID == 0)
            {
                filasAfectadas = mp.Insertar(estado);
            }
            else
            {
                filasAfectadas= mp.Updatear(estado);
            }

            return filasAfectadas;
        }

        public List<BE.ESTADO> ObtenerEstados()
        {
            List<BE.ESTADO> estados = new List<BE.ESTADO>();

            estados = mp.GetList();

            return estados;

        }

        public int Eliminar(BE.ESTADO estado)
        {
            int filasAfectadas = mp.Deletear(estado);
            return filasAfectadas;
        }
    }
}
