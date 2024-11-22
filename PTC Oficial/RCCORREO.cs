using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
namespace PTC_Oficial
{
    internal class RCCORREO
    {
        MailMessage correos = new MailMessage();
        SmtpClient envios = new SmtpClient();
        Conexion c = new Conexion();
        public void enviarCorreo(string emisor, string password, string mensaje, string asunto, string destinatario, string ruta)
        {
            try
            {
                correos.To.Clear();
                correos.Body = "";
                correos.Subject = "";
                correos.Body = mensaje;
                correos.Subject = asunto;
                correos.IsBodyHtml = true;
                correos.To.Add(destinatario.Trim());

                if (ruta.Equals("") == false)
                {
                    System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                    correos.Attachments.Add(archivo);
                }

                correos.From = new MailAddress(emisor);
                envios.Credentials = new NetworkCredential(emisor, password);

                envios.Host = "smtp.gmail.com";
                envios.Port = 587;
                envios.EnableSsl = true;

                envios.Send(correos);
                MessageBox.Show("El mensaje fue enviado correctamente",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
