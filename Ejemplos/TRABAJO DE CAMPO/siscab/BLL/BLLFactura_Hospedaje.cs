using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLFactura_Hospedaje
    {
        private DAL.mp_factura_hospedaje mapper = new DAL.mp_factura_hospedaje();
       

        public List<BE.Factura_Hospedaje> Listar()
        {
            return mapper.Listar();
        }

        public List<BE.Factura_Hospedaje> Listar_No_Pagos()
        {
            List<BE.Factura_Hospedaje> listaTMP = new List<Factura_Hospedaje>();
            listaTMP = Listar();
            List<BE.Factura_Hospedaje> listaNoPagos = new List<Factura_Hospedaje>();

            for (int i = 0; i < listaTMP.Count; i++)
            {
                if (listaTMP[i].Estado == EnumEstadoPago.NoPago)
                {
                    listaNoPagos.Add(listaTMP[i]);
                }          
            }
            return listaNoPagos;
        }


        //ESTO HAY QUE AGREGARLO EN EL ENTERPRISE
        public List<BE.Factura_Hospedaje> Listar_Pagos()
        {
            List<BE.Factura_Hospedaje> listaTMP = new List<Factura_Hospedaje>();
            listaTMP = Listar();
            List<BE.Factura_Hospedaje> listaPagos = new List<Factura_Hospedaje>();

            for (int i = 0; i < listaTMP.Count; i++)
            {
                if (listaTMP[i].Estado == EnumEstadoPago.Pago)
                {
                    listaPagos.Add(listaTMP[i]);
                }
            }
            return listaPagos;
        }



        public void Insertar (Factura_Hospedaje factura_Hospedaje)
        {
            mapper.Insertar(factura_Hospedaje);
        }

        public void Modificar(Factura_Hospedaje factura_Hospedaje)
        {
            mapper.Modificar(factura_Hospedaje);
        }

        public string GenerarNumero(DateTime fecha, int nro)
        {
            // ojo con el NRO que repite ya que el ID siempre va a ser cero
            int año = fecha.Year;
            int numero = nro + 10000;
            return año.ToString() + "-" + numero.ToString();
        }

        public float ObtenerTotalPagar(Factura facturaReserva)
        {
            return facturaReserva.Total - facturaReserva.Deposito;
        }

        public float ObtenerDeposito(Factura facturaReserva)
        {
            return facturaReserva.Deposito;
        }

        public float ObtenerTotalEstadia(Factura facturaReserva)
        {
            return facturaReserva.Total;
        }

      
        public void CambiarEstado(Pago_Estadia pe, Factura_Hospedaje fh)
        {
            List<Factura_Hospedaje> listaTMP = new List<Factura_Hospedaje>();
            listaTMP = Listar_No_Pagos();
                      
            for (int i = 0; i < listaTMP.Count; i++)
            {
                if (pe.FacturaHospedaje.Id == listaTMP[i].Id)
                {
                    mapper.Modificar(fh);
                }

            }
                   
        }
    }
}
