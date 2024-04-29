using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLReporte
    {              
        public float ObtenerTotalDepositoReservas(List<BE.Factura> lista)
        {
            float totalDeposito = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                totalDeposito += lista[i].Deposito;
            }
            return totalDeposito;
        }

        public float ObtenerTotalRestoAbonado(List<BE.Factura_Hospedaje> lista)
        {
            float totalRestoAbonado = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                totalRestoAbonado += lista[i].TotalPagar;
            }
            return totalRestoAbonado;
        }

        public List<BE.Factura> FiltrarFechas(DateTime fd, DateTime fh, List<BE.Factura> lista)
        {
            List<BE.Factura> listaTMP = new List<BE.Factura>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (fd <= lista[i].Fecha && fh >= lista[i].Fecha)
                {
                    listaTMP.Add(lista[i]);
                }
            }
            return listaTMP;
        }

        public List<BE.Factura_Hospedaje> FiltrarFechas(DateTime fd, DateTime fh, List<BE.Factura_Hospedaje> lista)
        {
            List<BE.Factura_Hospedaje> listaTMP = new List<BE.Factura_Hospedaje>();
            for (int i = 0; i < lista.Count; i++)
            {
                if (fd <= lista[i].Fecha && fh >= lista[i].Fecha)
                {
                    listaTMP.Add(lista[i]);
                }
            }
            return listaTMP;
        }

        public List<BE.Estadia> FiltrarFechasEstadias(DateTime fd, DateTime fh, List<BE.Estadia> lista)
        {
            List<BE.Estadia> listaTMP = new List<BE.Estadia>();
            for (int i = 0; i < lista.Count; i++)
            {          
                if (fd <= lista[i].Checkin && fh >= lista[i].Checkout)
                {
                    listaTMP.Add(lista[i]);
                }
                if (fd > lista[i].Checkin && fd < lista[i].Checkout && fh >= lista[i].Checkout)
                {
                    listaTMP.Add(lista[i]);
                }
                if (fd <= lista[i].Checkin && fh < lista[i].Checkout && fh > lista[i].Checkin)
                {
                    listaTMP.Add(lista[i]);
                }
            }
            return listaTMP;
        }

        public int ObtenerDias (DateTime fd, DateTime fh)
        {
            //Calcular la diferencia en días
            TimeSpan diferencia = fh.Subtract(fd);

            //Obtener la cantidad en días
            int diasDiferencia = (int)diferencia.TotalDays + 1;

            return diasDiferencia;
        }

        
        //Hay que probar esto
        public int DiferenciaDias (BE.Estadia estadia, DateTime fd, DateTime fh)
        {
            int diasCoincidentes;
            IEnumerable<DateTime> fechasCoincidentes = Enumerable.Range(0, (estadia.Checkout - estadia.Checkin).Days + 1)
                 .Select(offset => estadia.Checkin.AddDays(offset))
                 .Intersect(Enumerable.Range(0, (fh - fd).Days + 1)
                 .Select(offset => fd.AddDays(offset)));

            diasCoincidentes = fechasCoincidentes.Count();

            return diasCoincidentes;
        }

        public float ObtenerPorcentajeOcupacion (int totalDias, int dias)
        {
            float resultado;
            resultado = (dias * 100) / totalDias;
            return resultado;
        }


    }
}
