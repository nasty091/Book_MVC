using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Book.DataAccess.Repository.IRepository;
using System.Drawing.Text;

namespace Book.DataAccess.Repository
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string message)
        {
            var mail = "phamcaodaian.9a1@gmail.com";
            var pw = "biu123456789";

            //465,587
            var client = new SmtpClient("smtp.gmail.com", 456)
            {
                EnableSsl = true,
                //UseDefaultCredentials = false,
                Credentials = new NetworkCredential(mail, pw)
            };

            return client.SendMailAsync(
                new MailMessage(from: email,
                                to: mail,
                                subject,
                                message
                                ));
        }
    }
}
