using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Comanda
    {
        MP_Comanda mp = new MP_Comanda();
        public List<BE.Comanda> Listar()
        {
            return mp.GetAll();
        }


        public int Insertar(BE.Comanda comanda)
        {
            return mp.Insert(comanda);
        }


    }
}
