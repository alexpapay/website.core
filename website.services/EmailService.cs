using System.Collections.Generic;
using System.Linq;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using MimeKit.Text;
using website.core.Models.Email;
using website.services.Interfaces;

namespace website.services
{
    public class EmailService : IEmailService
    {
        private readonly IOptions<EmailConfiguration> _emailConfiguration;

        public EmailService(IOptions<EmailConfiguration> emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }

        /// <summary>
        /// Send email or emails for users list.
        /// </summary>
        /// <param name="emailMessage">EmailMessage object.</param>
        public void Send(EmailMessage emailMessage)
        {
            MimeMessage message = new MimeMessage();

            message.To.AddRange(emailMessage.ToAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));
            message.From.AddRange(emailMessage.FromAddresses.Select(x => new MailboxAddress(x.Name, x.Address)));

            message.Subject = emailMessage.Subject;
            message.Body = new TextPart(TextFormat.Html)
            {
                Text = emailMessage.Content
            };

            using var emailClient = new SmtpClient();

            emailClient.Connect(_emailConfiguration.Value.SmtpServer, _emailConfiguration.Value.SmtpPort,
                SecureSocketOptions.StartTls);
            emailClient.AuthenticationMechanisms.Remove("XOAUTH2");
            emailClient.Authenticate(_emailConfiguration.Value.SmtpUsername, _emailConfiguration.Value.SmtpPassword);

            emailClient.Send(message);

            emailClient.Disconnect(true);
        }

        /// <summary>
        /// Recieve mails. Default count is 10.
        /// </summary>
        /// <param name="maxCount">Maximum of the recieved mails. Default value is 10.</param>
        /// <returns>List of EmailMessage objects.</returns>
        public List<EmailMessage> ReceiveEmail(int maxCount = 10)
        {
            using var emailClient = new Pop3Client();

            emailClient.Connect(_emailConfiguration.Value.PopServer, _emailConfiguration.Value.PopPort, true);

            emailClient.AuthenticationMechanisms.Remove("XOAUTH2");

            emailClient.Authenticate(_emailConfiguration.Value.PopUsername, _emailConfiguration.Value.PopPassword);

            List<EmailMessage> emails = new List<EmailMessage>();

            for (int i = 0; i < emailClient.Count && i < maxCount; i++)
            {
                MimeMessage message = emailClient.GetMessage(i);
                EmailMessage emailMessage = new EmailMessage
                {
                    Content = !string.IsNullOrEmpty(message.HtmlBody) ? message.HtmlBody : message.TextBody,
                    Subject = message.Subject
                };

                emailMessage.ToAddresses.AddRange(message.To.Select(x => (MailboxAddress)x)
                    .Select(x => new EmailAddress { Address = x.Address, Name = x.Name }));
                emailMessage.FromAddresses.AddRange(message.From.Select(x => (MailboxAddress)x)
                    .Select(x => new EmailAddress { Address = x.Address, Name = x.Name }));

                emails.Add(emailMessage);
            }

            return emails;
        }
    }
}
