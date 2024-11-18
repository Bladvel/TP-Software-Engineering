using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;
using Interfaces;
using Services;

namespace BLL
{
    public class Pago
    {
        MP_Pago mp = MpPagoCreator.GetInstance().CreateMapper() as MP_Pago;

        public int Insertar(BE.Pago pago)
        {

            int resultado = mp.Insert(pago);
            if (resultado != -1)
            {
                var bitacora = new Services.Bitacora
                {
                    Fecha = DateTime.Now,
                    Usuario = SessionManager.Instance.User,
                    Modulo = TipoModulo.Pago,
                    Operacion = TipoOperacion.Alta,
                    Criticidad = 2
                };

                var bllBitacora = new BLL.Bitacora();
                bllBitacora.Insertar(bitacora);
                DVH.Recalcular(DVH.Listar(), Listar(), Concatenar, c => c.Id, "PAGO");
                DVV.Recalcular(Listar().Cast<object>().ToList(), typeof(BE.Pago));
            }


            return resultado;
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

                var bitacora = new Services.Bitacora
                {
                    Fecha = DateTime.Now,
                    Usuario = SessionManager.Instance.User,
                    Modulo = TipoModulo.Cobro,
                    Operacion = TipoOperacion.CobrarPedido,
                    Criticidad = 4
                };

                var bllBitacora = new BLL.Bitacora();
                bllBitacora.Insertar(bitacora);




                return true;
            }
            else if (nuevoPago.Metodo is BE.PagoEfectivo pagoEfectivo)
            {

                if (pagoEfectivo.Monto < nuevoPago.Total)
                {
                    return false;
                }


                var bitacora = new Services.Bitacora
                {
                    Fecha = DateTime.Now,
                    Usuario = SessionManager.Instance.User,
                    Modulo = TipoModulo.Cobro,
                    Operacion = TipoOperacion.CobrarPedido,
                    Criticidad = 4
                };

                var bllBitacora = new BLL.Bitacora();
                bllBitacora.Insertar(bitacora);


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
