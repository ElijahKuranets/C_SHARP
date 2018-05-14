using System;

namespace Mail
{
    class Program
    {
        static void Main()
        {
            ISendMail sendMail = new SendMail(new Logger());
            var mailModel = new MailModel
            {
                From = "gemar19@mail.ru",
                Message = "Женя кушать",
                Password = "lipnitza1993",
                SmptServer = "smtp.mail.ru",
                To = "p310162018@gmail.com",
                Caption = "лол"
            };

            sendMail.Send(mailModel);
            Console.ReadLine();
        }
    }
}
