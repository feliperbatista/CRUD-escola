using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_escola
{
    internal class Email
    {
        public static void EnviarEmail(string email, int codigo)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.office365.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential(Privado.email, Privado.senha);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                MailMessage mail = new MailMessage();
                mail.From = new(Privado.email);
                mail.To.Add(new MailAddress(email));
                mail.Subject = "Confirmação de cadastro";
                mail.Body = $"O seu código de confirmação de cadastro é '{codigo}'";
                mail.IsBodyHtml = false;

                smtpClient.Send(mail);
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível enviar o email.");
            }
        }
    }
}
