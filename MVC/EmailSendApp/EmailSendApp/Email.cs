using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace EmailSendApp
{
    class Email
    {
        public string senderEmail = ConfigurationManager.AppSettings["SenderEmail"];
        public string senderPassword = ConfigurationManager.AppSettings["Password"];
        string serverName = "smtp.gmail.com";
        int portNumber = 587;

        public void SendMail(string receiverEmail)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(senderEmail);
                mail.To.Add(receiverEmail);
                mail.Subject = "Hello Sir Sanal";
                mail.IsBodyHtml = true;
                mail.Body = "Sending Mail Using C# Console Application";
                using (SmtpClient client = new SmtpClient(serverName, portNumber))
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(senderEmail, senderPassword);
                    client.Send(mail);
                }
            }
        }
    }
}