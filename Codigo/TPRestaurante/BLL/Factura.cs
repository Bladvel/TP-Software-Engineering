﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using BE;
using DAL;
using DAL.FactoryMapper;
using Interfaces;
using Services;

namespace BLL
{
    public class Factura
    {
        MP_Factura mp = MpFacturaCreator.GetInstance().CreateMapper() as MP_Factura;
        OrdenDeCompra bllOrdenDeCompra = new OrdenDeCompra();
        PagoInsumo bllPagoInsumo = new PagoInsumo();
        BLL.Bitacora bllBitacora = new BLL.Bitacora();
        //DVH bllDvh = new DVH();

        public int Insertar(BE.Factura factura)
        {
            int resultado = -1;
            if (factura != null)
            {
                if (bllOrdenDeCompra.ActualizarEstado(factura.OrdenDeCompra, EstadoOrdenDeCompra.PendienteDePago) == -1)
                {


                    return -1;
                }
                else
                {

                    resultado = mp.Insert(factura);

                    if (resultado != -1)
                    {
                        var logUser = SessionManager.Instance.User;
                        var logEntry = new Services.Bitacora
                        {
                            Usuario = logUser,
                            Fecha = DateTime.Now,
                            Modulo = TipoModulo.Factura,
                            Operacion = TipoOperacion.Alta,
                            Criticidad = 2
                        };

                        bllBitacora.Insertar(logEntry);
                        DVH.Recalcular(DVH.Listar(), Listar(), Concatenar, c => c.NroFactura, "FACTURA");
                        DVV.Recalcular(Listar().Cast<object>().ToList(), typeof(BE.Factura));


                    }


                }

            }

            return resultado;
        }

        public int Actualizar(BE.Factura factura)
        {

            int resultado = mp.Update(factura);


            if (resultado != -1)
            {
                var logUser = SessionManager.Instance.User;
                var logEntry = new Services.Bitacora
                {
                    Usuario = logUser,
                    Fecha = DateTime.Now,
                    Modulo = TipoModulo.Factura,
                    Operacion = TipoOperacion.Modificacion,
                    Criticidad = 3
                };

                bllBitacora.Insertar(logEntry);
                DVH.Recalcular(DVH.Listar(), Listar(), Concatenar, c => c.NroFactura, "FACTURA");
                DVV.Recalcular(Listar().Cast<object>().ToList(), typeof(BE.Factura));
            }



            return resultado;
        }


        public List<BE.Factura> Listar()
        {
            return mp.GetAll();
        }

        public List<BE.Factura> ListarPendientesDePago()
        {
            List<BE.Factura> facturas = mp.GetAll();

            List<BE.Factura> facturasPendientes = facturas.FindAll(f =>
                f.Estado == EstadoFactura.Pendiente || f.Estado == EstadoFactura.PagadaParcialmente);
            return facturasPendientes;


        }

        public double ObtenerTotalPagado(BE.Factura factura)
        {
            double totalPagado = 0;
            foreach (BE.PagoInsumo pago in factura.Pagos)
            {
                totalPagado += pago.Monto;
            }

            return totalPagado;
        }

        public double ObtenerMontoTotal(BE.Factura factura)
        {
            return bllOrdenDeCompra.ObtenerTotal(factura.OrdenDeCompra);
        }


        public double ObtenerTotalAdeudado(BE.Factura factura)
        {


            double totalAdeudado = ObtenerMontoTotal(factura) - ObtenerTotalPagado(factura);


            return totalAdeudado;
        }

        public int ObtenerCuotaActualAPagar(BE.Factura factura)
        {
            int cuotaActual = factura.Pagos.Count + 1;
            return cuotaActual;
        }

        public string ProcesarPago(BE.PagoInsumo pago, BE.Factura factura)
        {
            if (factura == null)
            {
                return "Por la factura no puede ser nula";
            }

            if (pago == null)
            {
                return "El pago no puede ser nulo";
            }



            string resultado = "";

            int TotalCuotas = factura.TotalCuotas;
            int cuotasPagas = factura.Pagos.Count;
            int cuotaDelPago = pago.NroCuota;
            int cuotaActual = cuotasPagas + 1;
            double montoPago = pago.Monto;




            try
            {
                using (var transaction = new TransactionScope())
                {
                    if (cuotaDelPago == cuotaActual)
                    {
                        if (cuotaDelPago == TotalCuotas)
                        {
                            if (montoPago >= ObtenerTotalAdeudado(factura))
                            {
                                if (bllPagoInsumo.Insertar(pago) == -1)
                                {
                                    resultado = "Error al insertar pago";
                                    return resultado;
                                }

                                factura.Estado = EstadoFactura.Pagada;
                                Actualizar(factura);
                                bllOrdenDeCompra.ActualizarEstado(factura.OrdenDeCompra, EstadoOrdenDeCompra.Pagada);
                                resultado = "Factura pagada";

                            }
                            else
                            {
                                resultado = "Monto insuficiente para la ultima cuota";
                            }
                        }
                        else
                        {
                            if (montoPago >= ObtenerTotalAdeudado(factura))
                            {
                                resultado = "El monto de una cuota no puede ser igual o mayor al total adeudado";
                                return resultado;
                            }



                            if (bllPagoInsumo.Insertar(pago) == -1)
                            {
                                resultado = "Error al insertar pago";
                                return resultado;
                            }

                            factura.Estado = EstadoFactura.PagadaParcialmente;
                            int filasAfectadas = Actualizar(factura);

                            if (filasAfectadas != -1)
                            {
                                var logUser = SessionManager.Instance.User;
                                var logEntry = new Services.Bitacora
                                {
                                    Usuario = logUser,
                                    Fecha = DateTime.Now,
                                    Modulo = TipoModulo.Factura,
                                    Operacion = TipoOperacion.ProcesarPago,
                                    Criticidad = 4
                                };

                                bllBitacora.Insertar(logEntry);

                            }


                            resultado = "Pago procesado";
                        }
                    }
                    else
                    {
                        resultado = "Cuota incorrecta";
                    }

                    transaction.Complete();
                }
            }
            catch (Exception e)
            {
                resultado = "Ocurrió un error al procesar el pago. Por favor, inténtelo de nuevo.";
            }


            return resultado;



        }

        public string Concatenar(BE.Factura factura)
        {
            return factura.NroFactura.ToString() + factura.Fecha + factura.OrdenDeCompra.NroOrden +
                   factura.TotalCuotas + factura.MontoTotal + factura.Estado;

        }
    }
}
