using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BLL
{
    public class BLLFactura
    {
        DAL.mp_factura mapper= new DAL.mp_factura();

        public List<BE.Factura> Listar()
        {
            return mapper.Listar();
        }

        public void Insertar(BE.Factura factura)
        {
            mapper.Insertar(factura);
        }
        public void Modificar(BE.Factura factura)
        {
            mapper.Insertar(factura);
        }


        public float ObtenerSubtotal(Reserva reserva)
        {
            return reserva.Cantidad_Dias * reserva.Habitacion.Tipo.Precio;
        }

        public float ObtenerIVA(float subtotal)
        {
            return subtotal * 0.21f;
        }

        public float ObtenerTotal(float subtotal, float iva)
        {
            return subtotal + iva;
        }

        public float ObtenerDeposito(float total)
        {
            return total * 0.10f;
        }

        public string GenerarNumero(DateTime fecha, int nro)
        {                       
            // ojo con el NRO que repite ya que el ID siempre va a ser cero
            int año = fecha.Year;
            int numero = nro + 1000;
            
            return año.ToString() + "-" + numero.ToString();           
        }

        public bool ValidarFactura (string numeroFactura)
        {
            bool ok = false;
            List<Factura> facturas = new List<Factura>();
            facturas = mapper.Listar();

            for (int i = 0; i < facturas.Count; i++)
            {
                if (numeroFactura == facturas[i].Numero)
                {
                    ok = true;
                }
            }
            return ok;
        }

        public BE.Factura BuscarFactura (string numeroFactura)
        {
            BE.Factura factura = new BE.Factura();
            List<Factura> facturas = new List<Factura>();
            facturas = mapper.Listar();

            for (int i = 0; i < facturas.Count; i++)
            {
                if (numeroFactura == facturas[i].Numero)
                {
                    factura = facturas[i];
                }
            }
        return factura;
        }


        public Reserva BuscarReserva (string numeroFactura)
        {
            Reserva res = new Reserva();
            List<Factura> facturas= new List<Factura>();
            
            facturas = mapper.Listar();
            
            for (int i = 0; i < facturas.Count; i++)
            {
                if (numeroFactura == facturas[i].Numero)
                {
                    res = facturas[i].Reserva;
                }
            }
            return res;
        }


        

       






    }
}
