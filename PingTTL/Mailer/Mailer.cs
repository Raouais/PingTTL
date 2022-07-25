using PingTTL.Model;

namespace PingTTL.Mailer {
    internal class Mailer :Observer {


        private Email email;

        public Mailer(Email email) {
            this.email = email;
        }
        public void Update(Computer computer,string status) {

            string htmlBody = "" +
                "" +
                "" +
                "";

           //email.Send(htmlBody);
        }
    }
}
