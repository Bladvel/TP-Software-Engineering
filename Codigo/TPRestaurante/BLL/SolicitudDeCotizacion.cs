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
    public class SolicitudDeCotizacion
    {
        MP_SolicitudDeCotizacion mp = MpSolicitudDeCotizacionCreator.GetInstance.CreateMapper() as MP_SolicitudDeCotizacion;

        public List<BE.SolicitudDeCotizacion> Listar()
        {
            return mp.GetAll();
        }

        public List<BE.SolicitudDeCotizacion> ListarPorEstado(EstadoSolicitudCotizacion estado)
        {
            return mp.GetByState(estado);
        }


        public int RegistrarSolicitud(BE.SolicitudDeCotizacion solicitud)
        {
            return mp.Insert(solicitud);
        }

        public int CambiarEstado(BE.SolicitudDeCotizacion solicitud, EstadoSolicitudCotizacion estado)
        {
            solicitud.Estado = estado;
            return mp.Update(solicitud);
        }

        public int ActualizarItems(BE.SolicitudDeCotizacion solicitud)
        {
            return mp.UpdateItems(solicitud);
        }

        public int ActualizarEstadoSolicitud(BE.SolicitudDeCotizacion solicitudSeleccionada, EstadoSolicitudCotizacion estado)
        {
            int resultado = CambiarEstado(solicitudSeleccionada, estado);
            
            if (estado != EstadoSolicitudCotizacion.Rechazada && resultado != -1)
            {
                resultado = ActualizarItems(solicitudSeleccionada);
                
            }
            
            return resultado;
        }


        public string EnviarCorreoSolicitud(BE.SolicitudDeCotizacion solicitud, BE.Proveedor proveedor)
        {
            string mensaje = "";
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                smtpServer.Port = 587; // Puerto de Gmail para SSL
                smtpServer.Credentials = new NetworkCredential("stevebladvel@gmail.com", "igaq ffaf sutz jhgh"); //super inseguro actualmente
                smtpServer.EnableSsl = true;


                mail.From = new MailAddress("stevebladvel@gmail.com");
                mail.To.Add(proveedor.Email);
                mail.Subject = $"Solicitud de Compra N° {solicitud.NroSolicitud}";
                mail.Body = CrearCuerpoDelCorreo(solicitud, proveedor);  

                
                smtpServer.Send(mail);

                mensaje = "Correo enviado correctamente a " + proveedor.Email;
            }
            catch (Exception ex)
            {
                mensaje= "Error al enviar correo: " + ex.Message;
            }
            
            return mensaje;
        }


        
        private string CrearCuerpoDelCorreo(BE.SolicitudDeCotizacion solicitud, BE.Proveedor proveedor)
        {
            
            string cuerpo = $"Estimado {proveedor.Nombre},\n\n";
            cuerpo += $"Le enviamos la solicitud de compra N° {solicitud.NroSolicitud} realizada el {solicitud.Fecha}.\n";
            cuerpo += "Detalles de la solicitud:\n";

            foreach (var item in solicitud.Ingredientes)
            {
                cuerpo += $"- {item.Ingrediente.Nombre}, Cantidad: {item.CantidadRequerida}\n";
            }

            cuerpo += "\nSaludos cordiales.\n.";
            return cuerpo;
        }



    }
}
