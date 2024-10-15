using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;

namespace BLL
{
    public class Pago
    {
        MP_Pago mp = MpPagoCreator.GetInstance().CreateMapper() as MP_Pago;

        public int Insertar(BE.Pago pago)
        {
            return mp.Insert(pago);
        }


        public bool ProcesarPago(BE.Pago nuevoPago)
        {
            // Simulación de procesamiento del pago

            if (nuevoPago.Metodo is BE.PagoTarjeta pagoTarjeta)
            {
                // Validar los datos de la tarjeta
                if (string.IsNullOrWhiteSpace(pagoTarjeta.Titular) ||
                    pagoTarjeta.NumeroTarjeta <= 0 ||
                    pagoTarjeta.FechaVencimiento <= DateTime.Now ||
                    pagoTarjeta.Cvv <= 0)
                {

                    return false;
                }


                return true;
            }
            else if (nuevoPago.Metodo is BE.PagoEfectivo pagoEfectivo)
            {

                if (pagoEfectivo.Monto < nuevoPago.Total)
                {
                    return false;
                }

                return true;
            }


            return false;
        }

        public string Concatenar(BE.Pago pago)
        {
            return pago.Id.ToString() + pago.Fecha + pago.Total + pago.Metodo.id + pago.Pedido.NroPedido;
        }


        public List<BE.Pago> Listar()
        {
            return mp.GetAll();
        }
    }
}
