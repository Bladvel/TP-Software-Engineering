using Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLClienteBitacora
    {
        private DAL.mp_clienteBitacora mapper = new DAL.mp_clienteBitacora();
        private DAL.mp_cliente mapperCliente = new DAL.mp_cliente();

        public List<ClienteBitacora> Listar()
        {
            return mapper.Listar();
        }

        public void Insertar(ClienteBitacora cliBit)
        {
            mapper.Insertar(cliBit);
        }

        public void Desactivar(int dni)
        {
            List<ClienteBitacora> clienteBits = new List<ClienteBitacora>();
            clienteBits = Listar();

            for (int i = 0; i < clienteBits.Count; i++)
            {
                if (dni == clienteBits[i].Dni && clienteBits[i].Activo == 1)
                {
                    mapper.Desactivar(clienteBits[i]);
                }
            }
        }

        public void Reactivar (ClienteBitacora cliBit)
        {
            mapper.Reactivar(cliBit);
        }

        public bool VerificarRegistroActivo(ClienteBitacora cliBit)
        {
            bool ok = false;
            if (cliBit.Activo == 1)
            {
                ok = true;
            }
            return ok;
        }

        public List<ClienteBitacora> ConsultarDNI (int dni)
        {
            List<ClienteBitacora> clienteBits = new List<ClienteBitacora>();
            clienteBits = Listar();
            List<ClienteBitacora> clienteBitsFinal = new List<ClienteBitacora>();

            for (int i = 0; i < clienteBits.Count; i++)
            {
                if (dni == clienteBits[i].Dni)
                {
                    clienteBitsFinal.Add(clienteBits[i]);
                }
            }
            return clienteBitsFinal;
        }

        public void RestaurarCambiosTablaCliente(ClienteBitacora cliBit)
        {
            BE.Cliente cliente = new BE.Cliente();
            cliente.Id = cliBit.Cliente.Id;
            cliente.Nombre = cliBit.Nombre;
            cliente.Apellido = cliBit.Apellido;
            cliente.Dni = cliBit.Dni;
            cliente.Telefono_Fijo = cliBit.Telefono_Fijo;
            cliente.Telefono_Movil = cliBit.Telefono_Movil;

            cliente.Email = cliBit.Email;
            cliente.Domicilio = cliBit.Domicilio;
            cliente.Borrado = cliBit.Borrado;
            
            mapperCliente.Modificar(cliente);
        }


        public List<ClienteBitacora> FiltrarPorFechas (DateTime fechaDesde, DateTime fechaHasta)
        {
            List<ClienteBitacora> clienteBitacoras= new List<ClienteBitacora>();            
            clienteBitacoras = Listar();
            List<ClienteBitacora> clienteBitacorasTMP = new List<ClienteBitacora>();

            for (int i = 0; i < clienteBitacoras.Count; i++)
            {
                if (clienteBitacoras[i].UltimaModificacion > fechaDesde && clienteBitacoras[i].UltimaModificacion < fechaHasta)
                {
                    clienteBitacorasTMP.Add(clienteBitacoras[i]);
                }
            }
            return clienteBitacorasTMP;
        }


    }
}
