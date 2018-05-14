using System.Net;
using System.Net.Mail;
using System.Threading;

namespace Mail
{
   public class SendMail : ISendMail
    {
        MailMessage mail = new MailMessage();
        SmtpClient client = new SmtpClient();
        private readonly Ilogger _ilogger;
        public SendMail(Ilogger logger)
        {
            _ilogger = logger;
        }
        public void Send(MailModel mailModel)
        {

           
           
            
                mail.From = new MailAddress(mailModel.From);
                mail.To.Add(new MailAddress(mailModel.To));
                mail.Subject = mailModel.Caption;
                mail.Body = mailModel.Message;

                if (!string.IsNullOrEmpty(mailModel.AttachFile))
                    mail.Attachments.Add(new Attachment(mailModel.AttachFile));

               
                {
                    client.Host = mailModel.SmptServer;
                    client.Port = 25;
                    client.Credentials = new NetworkCredential(mailModel.From, mailModel.Password);
                    client.EnableSsl = true;
                };
                client.SendCompleted += Client_SendCompleted;
              
                client.SendAsync(mail, new CancellationToken());
           
           
        }

        private void Client_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error == null)
                _ilogger.WriteInfo("READMESSAGE");

            else
            {
                _ilogger.WriteError("ISN'T WORKING");

            }
           

            mail.Dispose();
            client.Dispose();
            
           
        }
    }
}
