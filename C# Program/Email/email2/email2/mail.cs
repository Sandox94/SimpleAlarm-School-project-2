using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace email2
{
    public class mail
    {
        private string smtpAddress = "smtp.live.com"; //smtp.live.com for hotmail. smtp.gmail.com for gmail. smtp.mail.yahoo.com for Yahoo!
        private int portNumber = 587;
        private bool enableSSL = true;
        private string emailFrom = "alarmgruppe3@hotmail.com";
        private string password = "hitalarm123";
        public string emailTo { get; set; }
        private string subject = "Alarm utløst";
        public string body { get; set; }

        public void Send(string emailTo, string body)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFrom);
                mail.To.Add(emailTo);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFrom, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }
    }
}
