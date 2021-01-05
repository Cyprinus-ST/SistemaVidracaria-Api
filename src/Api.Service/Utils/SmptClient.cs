using MimeKit;
using System.Net.Mail;
using System.Net;
using System;

namespace Api.Service.Utils
{
    public class SmptClient
    {
        public void SendEmail(string receiver, string? copies, string? hiddenCopies, string subject, string body)
        {
            try
            {
                var mail = new MailMessage();

                mail.From = new MailAddress("cyprinuscontato@gmail.com");
                mail.To.Add(receiver);

                if (!String.IsNullOrEmpty(copies))
                {
                    mail.CC.Add(new MailAddress(copies));
                }
                if (!String.IsNullOrEmpty(hiddenCopies))

                {
                    mail.Bcc.Add(new MailAddress(hiddenCopies));
                }

                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;

                var smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("cyprinuscontato@gmail.com", "cyprinus@gmail");

                smtp.Send(mail);

            } catch(Exception e)
            {
                throw e;
            }
        }
    }
}
