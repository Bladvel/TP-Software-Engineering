using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Cliente
    {
        MP_Cliente mp = new MP_Cliente();
        public void Insertar(BE.Cliente cliente)
        {
            mp.Insert(cliente);
        }

        public List<BE.Cliente> Listar()
        {
            return mp.GetAll();
        }



    }
}
