using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Prosjekt
{
    public class Mail
    {
        // Sets up standard e-mail properties, like e-mail server(smtpAddress), portnumber and SSL (encrypted connection)
        private string smtpAddress = "smtp.live.com"; //smtp.live.com for hotmail. smtp.gmail.com for gmail. smtp.mail.yahoo.com for Yahoo!
        private int portNumber = 587;
        private bool enableSSL = true;
        private string emailFrom = "alarmgruppe3@hotmail.com";
        private string password = "hitalarm123";
        private string attachmentFilename = null;
        public bool EmailSent { get; private set; }
        MailMessage mail;

        // Constructor wihtout filename
        public Mail (string emailTo, string subject, string body)
        {
            mail = new MailMessage();
            EmailSent = false;
            mail.From = new MailAddress(emailFrom);
            mail.To.Add(emailTo);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = false;
        }

        // Constructor with filename
        public Mail (string emailTo, string subject, string body, string attachmentFilename)
        {
            mail = new MailMessage();
            EmailSent = false;
            mail.From = new MailAddress(emailFrom);
            mail.To.Add(emailTo);
            mail.Subject = subject;
            mail.Body = body;
            mail.IsBodyHtml = false;
            this.attachmentFilename = attachmentFilename;
        }

        /// <summary>
        /// Send email, and set EmailSent to true if email is sent
        /// </summary>
        public void Send()
        {
            if (attachmentFilename != null) mail.Attachments.Add(new Attachment(attachmentFilename));

            SmtpClient smtp = new SmtpClient(smtpAddress, portNumber);
            smtp.Credentials = new NetworkCredential(emailFrom, password);
            smtp.EnableSsl = enableSSL;
            smtp.Send(mail);
            EmailSent = true;
        }
    }
}
