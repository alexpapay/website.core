using website.core.Services.Email.Interfaces;

namespace website.core.Services.Email.Models
{
    public class EmailConfiguration : IEmailConfiguration
    {
        public string SmtpServer { get; set; }

        public int SmtpPort { get; set; }

        public string SmtpUsername { get; set; }

        public string SmtpPassword { get; set; }

        public string PopServer { get; set; }

        public int PopPort { get; set; }

        public string PopUsername { get; set; }

        public string PopPassword { get; set; }

        public string MailFrom { get; set; }

        public string MailTo { get; set; }
    }
}
