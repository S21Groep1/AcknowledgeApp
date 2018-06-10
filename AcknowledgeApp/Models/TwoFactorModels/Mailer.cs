using System.Net;
using System.Net.Mail;

namespace Models
{
    public class Mailer
    {
        public void SendMail(string emailUser, int authnum)
        {
            SmtpClient smtp = new SmtpClient();

            MailMessage mailMessage = new MailMessage();
            mailMessage.From = new MailAddress("fproftaak@gmail.com");
            mailMessage.To.Add(emailUser);
            mailMessage.Subject = "Authentication code";
            mailMessage.Body = authnum.ToString();

            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("fproftaak@gmail.com", "Proftaakie");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;

            smtp.Send(mailMessage);
        }
    }
}