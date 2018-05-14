using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Mail;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SendMail_SuccessSending()
        {
            var mock = new Mock<Ilogger>();
            mock.Setup(a => a.WriteError(It.IsAny<string>()));
            mock.Setup(a => a.WriteInfo(It.IsAny<string>()));
            Mail.SendMail smail = new SendMail(mock.Object);
            var mailModel = new MailModel
            {
                From = "gemar19@mail.ru",
                Message = "Женя кушать",
                Password = "lipnitza1993",
                SmptServer = "smtp.mail.ru",
                To = "p310162018@gmail.com",
                Caption = "лол"
            };
            try
            {
                smail.Send(mailModel);
            }
            catch (Exception)
            {
                Assert.Fail();
            }

        }
        [TestMethod]
        public void SendMail_FailSending()
        {
            var mock = new Mock<Ilogger>();
            mock.Setup(a => a.WriteError(It.IsAny<string>()));
            mock.Setup(a => a.WriteInfo(It.IsAny<string>()));
            Mail.SendMail smail = new SendMail(mock.Object);
            var mailModel = new MailModel
            {
                From = "gemar19@mail.ru",
                Message = "Женя кушать",
                Password = "lipnitza19",
                SmptServer = "smtp.mail.ru",
                To = "p310162018@gmail.com",
                Caption = "лол"
            };
            try
            {
                smail.Send(mailModel);
                Assert.Fail();
            }
            catch (Exception)
            {
              
            }

        }
    }
}
