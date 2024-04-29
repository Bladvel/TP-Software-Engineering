using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCliente
    {

        private DAL.mp_cliente mapper = new DAL.mp_cliente ();


        public List<BE.Cliente> ListarTodos()
        {
            return mapper.ListarTodos();
        }

        public List<BE.Cliente> ListarActivos()
        {
            return mapper.ListarActivos();
        }

        public List<BE.Cliente> ListarBorrados()
        {
            return mapper.ListarBorrados();
        }

        public void Grabar(BE.Cliente cliente)
        {
            if (cliente.Id == 0)
            {
                mapper.Insertar(cliente);
            }
            else
            {
                mapper.Modificar(cliente);
            }
        }

        public bool VerificarClienteExistente(int dni)
        {
            bool ok = false;
            List<BE.Cliente> clientesExistentes = new List<BE.Cliente>();
            clientesExistentes = mapper.ListarTodos();

            for (int i = 0; i < clientesExistentes.Count; i++)
            {
                if (clientesExistentes[i].Dni == dni)
                {
                    ok = true;
                }
            }
            return ok;
        }

        public BE.Cliente BuscarIdCliente(int dni)
        {
            List<BE.Cliente> clientesExistentes = new List<BE.Cliente>();
            clientesExistentes = mapper.ListarTodos();
            BE.Cliente clienteTMP = new BE.Cliente();
            for (int i = 0; i < clientesExistentes.Count; i++)
            {
                if (clientesExistentes[i].Dni == dni)
                {
                    clienteTMP = clientesExistentes[i];
                }
            }
            return clienteTMP;
        }
    }
}
