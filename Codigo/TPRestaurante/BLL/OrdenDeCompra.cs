using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.FactoryMapper;
using Interfaces;

namespace BLL
{
    public class OrdenDeCompra
    {
        MP_OrdenDeCompra mp = MpOrdenDeCompraCreator.GetInstance.CreateMapper() as MP_OrdenDeCompra;
        SolicitudDeCotizacion bllSolicitudDeCotizacion = new SolicitudDeCotizacion();

        public List<BE.OrdenDeCompra> Listar()
        {
            return mp.GetAll();
        }


        public List<BE.OrdenDeCompra> ListarPorEstadoDeOrden(Interfaces.EstadoOrdenDeCompra estado)
        {
            return mp.GetByOrderState(estado);
        }

        
        public int Insertar(BE.OrdenDeCompra ordenDeCompra)
        {
            int id = mp.Insert(ordenDeCompra);
            if (id!=-1)
            {
                if (bllSolicitudDeCotizacion.ActualizarEstadoSolicitud(ordenDeCompra.Solicitud,
                        EstadoSolicitudCotizacion.CotizacionAprobada) == -1)
                {
                    id = -1;
                }
            }
            return id;
        }


        public int ActualizarEstado(BE.OrdenDeCompra ordenDeCompra, EstadoOrdenDeCompra estado)
        {
            ordenDeCompra.EstadoOrden = estado;
            return mp.Update(ordenDeCompra);
        }

        //public int ActualizarEstadoDeCarga(BE.OrdenDeCompra ordenDeCompra, EstadoCargaDeInsumos estado)
        //{
        //    ordenDeCompra.EstadoCarga = estado;
        //    return mp.Update(ordenDeCompra);
        //}


        public string EnviarEmail(BE.OrdenDeCompra orden)
        {
            string mensaje = "";
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                smtpServer.Port = 587; 
                smtpServer.Credentials = new NetworkCredential("stevebladvel@gmail.com", "igaq ffaf sutz jhgh"); //super inseguro actualmente
                smtpServer.EnableSsl = true;

                mail.From = new MailAddress("stevebladvel@gmail.com");
                mail.To.Add(orden.Proveedor.Email);
                mail.Subject = $"Orden de Compra N° {orden.NroOrden}";
                mail.Body = CrearCuerpoCorreoOrdenCompra(orden);

                smtpServer.Send(mail);

                mensaje = "Correo enviado correctamente a " + orden.Proveedor.Email;
            }
            catch (Exception ex)
            {
                mensaje = "Error al enviar correo: " + ex.Message;
            }

            return mensaje;
        }

        
        private string CrearCuerpoCorreoOrdenCompra(BE.OrdenDeCompra orden)
        {
            StringBuilder cuerpo = new StringBuilder();
            cuerpo.AppendLine($"Estimado {orden.Proveedor.Nombre},");
            cuerpo.AppendLine();
            cuerpo.AppendLine("Se adjunta la orden de compra con los siguientes detalles:");
            cuerpo.AppendLine($"Número de Orden: {orden.NroOrden}");
            cuerpo.AppendLine($"Fecha de Emisión: {orden.Fecha}");
            cuerpo.AppendLine($"Proveedor: {orden.Proveedor.Nombre}");
            cuerpo.AppendLine($"Condición de Pago: {orden.CondicionDePago}");
            cuerpo.AppendLine();
            cuerpo.AppendLine("Detalles de la Orden:");

            foreach (var item in orden.Solicitud.Ingredientes)
            {
                cuerpo.AppendLine($"- {item.Ingrediente.Nombre}: {item.CantidadRequerida} unidades a ${item.PrecioCotizacion} cada una");
            }

            cuerpo.AppendLine();
            cuerpo.AppendLine("Por favor, confirme la recepción de esta orden de compra.");
            cuerpo.AppendLine();
            cuerpo.AppendLine("Atentamente,");
            cuerpo.AppendLine("Departamento de Compras");

            return cuerpo.ToString();
        }


        public double ObtenerTotal(BE.OrdenDeCompra ordenSeleccionada)
        {
            return ordenSeleccionada.Solicitud.Ingredientes.Sum(i => i.CantidadRequerida * i.PrecioCotizacion);
        }
    }
}
