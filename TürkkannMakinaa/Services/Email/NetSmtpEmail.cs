using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TürkkannMakinaa.Services.Email
{
    public class NetSmtpEmail : IEmailSender
    {
        public Task SendEmailAsync(string email,string subject , string htmlMessage)
        {
			try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.To.Add(email);
                mail.Subject = subject;
                mail.Body = htmlMessage;
                mail.IsBodyHtml = true;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("deneme.talha12", "123456789o+");
                SmtpServer.EnableSsl = true;


                SmtpServer.Send(mail);

                return Task.FromResult("E-Posta Gönderildi");
			}
			catch (Exception ex)
			{

				return Task.FromResult("Hata tekrar deneyiniz");
			}
        }
    }
}
