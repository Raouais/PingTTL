using PingTTL.Model;
using System;
using System.Net;
using System.Net.Mail;

namespace PingTTL.Mailer {
    public class Mailer : Observer {


        private Email email;
        private string computerCurrrentStatus;
        private MailMessage message = new MailMessage();
        private SmtpClient smtpClient = new SmtpClient();

        public Email Email { get => email; set => email = value; }
        public string ComputerCurrrentStatus{ get => computerCurrrentStatus; set => computerCurrrentStatus = value; }

        public Mailer(Email email) {
            Email = email;
            ComputerCurrrentStatus = Task.INIT;
            message.From = new MailAddress(Email.FromMailAddress);
            message.To.Add(new MailAddress(Email.ToMailAddress));
            message.Subject = Email.Subject;
            message.IsBodyHtml = true;
            smtpClient.Port = Email.Port;
            smtpClient.Host = Email.Host;
            smtpClient.EnableSsl = Email.Ssl;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(Email.FromMailAddress,Email.Password);
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        }
        public void Update(Computer computer,string status) {
            string title = "<h1>PingTTL Info</h1></br>";
            string goodNews = "<p>La machine " + computer.Name + " réponds à nouveaux.</p>";
            string badNews = "<p>La machine " + computer.Name + " ne réponds plus.</p>";


            if(ComputerCurrrentStatus != Task.INIT) {
                if(status == Task.OUTREACH) {
                    Send(title + badNews);
                } else if(ComputerCurrrentStatus == Task.OUTREACH && status == Task.WORKING) {
                    Send(title + goodNews);
                }
            } else if(ComputerCurrrentStatus == Task.INIT) {
                if(status == Task.OUTREACH) {
                    Send(title + badNews);
                }
            }
            ComputerCurrrentStatus = status;
        }

        public void Send(string body) {
            message.Body = body;
            try {
                smtpClient.Send(message);
            } catch(Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }

        public bool IsConnectionOk() {
            bool isSent = false;
            message.Body = "<h1>PingTTL testing connection</h1>";
            try {
                smtpClient.Send(message);
                isSent = true;
            } catch(Exception) {
                throw new EmailConnectionException("Erreur couriel: La connexion a échoué. Voir README");
            }
            return isSent;
        }
    }
}
