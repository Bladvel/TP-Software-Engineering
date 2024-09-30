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

        public string Modificar(BE.Cliente cliente)
        {
            string result;
            if (mp.Update(cliente) != -1)
            {
                result = "Cliente modificado con éxito";
            }
            else
            {
                result = "Error al modificar cliente";
            }

            return result;
        }

        public string Eliminar(BE.Cliente cliente)
        {
            string result;
            if (mp.Delete(cliente) != -1)
            {
                result = "Cliente eliminado con éxito";
            }
            else
            {
                result = "Error al eliminar cliente";
            }

            return result;
        }
    }
}
