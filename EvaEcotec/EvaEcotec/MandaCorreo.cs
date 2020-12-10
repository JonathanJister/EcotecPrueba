using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace EvaEcotec
{
    public class MandaCorreo
    {
        

        private readonly IConfiguration Configuration;

        public MandaCorreo(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void MandaCorreoContacto(string nombre, string correo, string direccion, string fecha)
        {
            
            string mailOrigen = Configuration["ConfigCorreo:CorreoOrigen"];
            string mailDestino = Configuration["ConfigCorreo:CorreoDestino"];
            string password = Configuration["ConfigCorreo:password"];
            string body = GeneraBody(nombre, correo, direccion, fecha);

            MailMessage oMailMessage = new MailMessage(from: mailOrigen, to: mailDestino, subject: "Green Leaves Contacto", body: body);

            oMailMessage.IsBodyHtml = true;

            SmtpClient oSmtpClient = new SmtpClient("smtp.gmail.com");
            oSmtpClient.EnableSsl = true;
            oSmtpClient.UseDefaultCredentials = false;
            oSmtpClient.Port = 587;
            oSmtpClient.Credentials = new System.Net.NetworkCredential(mailOrigen, password);

            oSmtpClient.Send(oMailMessage);

            oSmtpClient.Dispose();

        }

        public string GeneraBody(string nombre, string correo, string direccion, string fecha)
        {
            string body;

            body = @"<img src='green.png'><h1 class='display-4 text-center'>Green Leaves<i class=´'fas fa-leaf'></i></h1></div></div><hr><div class='row'><div class='col-md-5'><p>Estimado " + nombre + ",</p><br><p>Hemos recibido sus datos y nos pondremos en contacto con usted en la brevedad posible.Enviaremos un correo con información a su cuenta: " +correo + ".</p><br><p align='right'> Atte.</ p><p align='right'> Green Leaves</p><p align='right' >" +direccion + " a " + fecha + ".</ p ></ div ></ div >";

            return body;
        }
       
    }
}
