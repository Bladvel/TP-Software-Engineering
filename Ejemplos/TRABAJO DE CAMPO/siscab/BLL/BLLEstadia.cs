using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLEstadia
    {

        private DAL.mp_estadia mapper = new DAL.mp_estadia();  
        

        public List<BE.Estadia> Listar()
        {
            return mapper.Listar();
        }

        public List<Estadia> ListarActivas()
        {
            List<Estadia> estadias = mapper.Listar();
            List<Estadia> estadiasTMP = new List<Estadia>();

            for (int i = 0; i < estadias.Count; i++)
            {
                if (estadias[i].Estado == EnumEstadoEstadia.Activa)
                {
                    estadiasTMP.Add(estadias[i]);
                }
            }
            return estadiasTMP;
        }

        public List<Estadia> ListarPendientesPago()
        {
            List<Estadia> estadias = mapper.Listar();
            List<Estadia> estadiasTMP = new List<Estadia>();

            for (int i = 0; i < estadias.Count; i++)
            {
                if (estadias[i].Estado == EnumEstadoEstadia.Pendiente_Pago)
                {
                    estadiasTMP.Add(estadias[i]);
                }
            }
            return estadiasTMP;
        }


        public bool ValidarCliente (Cliente cliente)
        {
            
            bool ok = false;
            List<BE.Estadia> estadiasActivas = new List<BE.Estadia>();
            estadiasActivas = ListarActivas();

            for (int i = 0; i < estadiasActivas.Count; i++)
            {
                if (estadiasActivas[i].Cliente.Id == cliente.Id)
                {
                    ok = true;
                }
            }
            return ok;
        }

        public List<Estadia> BuscarEstadia (int dniCliente)
        {
            List<Estadia> estadias = ListarPendientesPago();
            List<Estadia> estadiasTMP = new List<Estadia>();
          
            
            for (int i = 0; i < estadias.Count; i++)
            {
                if (dniCliente == estadias[i].Cliente.Dni)
                {
                    estadiasTMP.Add(estadias[i]);
                }
            }
            return estadiasTMP;

        }



        public Estadia BuscarEstadia(Cliente cliente)
        {

            List<Estadia> estadias = ListarActivas();
            Estadia estadia = new Estadia();

            for (int i = 0; i < estadias.Count; i++)
            {
                if (cliente.Id == estadias[i].Cliente.Id)
                {
                    estadia = estadias[i];
                }
            }
            return estadia;

        }

        public void RealizarCheckin(Estadia estadia)
        {
            mapper.Insertar(estadia);
        }

        public void RealizarCheckout(Estadia estadia)
        {
            mapper.Modificar(estadia);
        }

        public void RealizarCheckoutAntes(Estadia estadia)
        {
            mapper.ModificarFechaSalida(estadia);
        }


        public bool ValidarEstadia (string numeroFactura)
        {
            bool ok = false;
            List<BE.Estadia> estadias = mapper.Listar();

            for (int i = 0; i < estadias.Count; i++)
            {
                if (numeroFactura == estadias[i].FacturaReserva.Numero)
                {
                    ok= true;
                }
            }
            return ok;
        }

        public bool VerificarFechaSalida(DateTime fechaActual, DateTime fechaCheckout)
        {
           bool ok = false;
            if (fechaActual.Day == fechaCheckout.Day && fechaActual.Month == fechaCheckout.Month && fechaActual.Year == fechaCheckout.Year)
            {
                ok = true;
            }
            return ok;
        }

        public void CambiarEstado(Factura_Hospedaje fh, Estadia es)
        {
            List<Estadia> listaTMP = new List<Estadia>();
            listaTMP = ListarPendientesPago();

            for (int i = 0; i < listaTMP.Count; i++)
            {
                if (fh.Estadia.Id == listaTMP[i].Id)
                {
                    mapper.Modificar(es);
                }

            }

        }

    }
}
