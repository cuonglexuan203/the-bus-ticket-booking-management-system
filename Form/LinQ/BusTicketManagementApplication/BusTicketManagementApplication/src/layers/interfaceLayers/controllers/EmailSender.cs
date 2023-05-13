using System;
using System.Threading.Tasks;
using BusTicketManagementApplication.src.env.locals;
using BusTicketManagementApplication.src.layers.interfaceLayers.controllers.interfaces;
using MailKit.Net.Smtp;
using MimeKit;

namespace BusTicketManagementApplication.src.layers.interfaceLayers.controllers
{
    internal class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string body)
        {
            string host = "smtp.gmail.com";
            int port = 465;
            string username = LocalEnv.EmailServerName;
            string password = LocalEnv.EncodedEmailServerPassword;
            //
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("FUTA Bus Lines", "noreply03@futa.vn"));
            message.To.Add(MailboxAddress.Parse(email));
            message.Subject = subject;
            //
            BodyBuilder builder = new BodyBuilder();
            builder.HtmlBody = body;
            message.Body = builder.ToMessageBody();
            //
            SmtpClient smtpClient = new SmtpClient();
            //
            smtpClient.Connect(host, port, true);
            smtpClient.Authenticate(username, password);
            return smtpClient.SendAsync(message);
        }
    }
}
