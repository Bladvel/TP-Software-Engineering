using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Seguridad
{
    public class EnvioCorreo
    {
        private readonly string _smtpHost = "smtp.gmail.com"; //servidor SMTP
        private readonly int _smtpPort = 587; // Puerto para TLS
        private readonly string _smtpUsuario = "luisfelipeguillenmarquez@gmail.com"; 
        private readonly string _smtpContrasena = "fqvs vfmi jsaf yiru"; 

        public void EnviarCorreo(string destinatario, string asunto, string cuerpo)
        {
            try
            {
                using (SmtpClient smtpClient = new SmtpClient(_smtpHost, _smtpPort))
                {
                    smtpClient.Credentials = new NetworkCredential(_smtpUsuario, _smtpContrasena);
                    smtpClient.EnableSsl = true;

                    MailMessage mailMessage = new MailMessage
                    {
                        From = new MailAddress(_smtpUsuario),
                        Subject = asunto,
                        Body = cuerpo,
                        IsBodyHtml = true
                    };
                    mailMessage.To.Add(destinatario);

                    smtpClient.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones, por ejemplo, registrar el error
                throw new Exception("Error al enviar el correo: " + ex.Message);
            }
        }
    }
}
