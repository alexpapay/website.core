using System.Collections.Generic;
using website.core.Services.Email.Models;

namespace website.core.Services.Email.Interfaces
{
    public interface IEmailService
    {
        /// <summary>
        /// Send email or emails for users list.
        /// </summary>
        /// <param name="emailMessage">EmailMessage object.</param>
        void Send(EmailMessage emailMessage);

        /// <summary>
        /// Recieve mails. Default mails count is 10.
        /// </summary>
        /// <param name="maxCount">Maximum of the recieved mails. Default value is 10.</param>
        /// <returns>List of EmailMessage objects.</returns>
        List<EmailMessage> ReceiveEmail(int maxCount = 10);
    }
}