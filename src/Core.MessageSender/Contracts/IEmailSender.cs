using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Amazon.SimpleEmail.Model;
using Core.MessageSender.Contracts.Models;

namespace Core.MessageSender.Contracts
{
    public interface IEmailSender
    {
        /// <summary>
        /// Sends <see cref="EmailMessage"/> asynchronously.
        /// </summary>
        /// <param name="email">Message parameters.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation
        /// with <see cref="SendResponse"/> representing result of message sending.</returns>
        Task<SendResponse> SendAsync(EmailMessage email);
        /// <summary>
        /// Sends <see cref="EmailMessage"/> asynchronously.
        /// </summary>
        /// <param name="email">Message parameters.</param>
        /// <returns>A <see cref="Task"/> representing the synchronous operation
        /// with <see cref="SendResponse"/> representing result of message sending.</returns>
        SendResponse Send(EmailMessage email);
        /// <summary>
        /// Sends <see cref="EmailMessage"/> asynchronously.
        /// </summary>
        /// <param name="email">Message parameters.</param>
        /// <returns>A <see cref="Task"/> representing the synchronous operation for email creating
        /// with <see cref="SendEmailRequest"/> representing result of message sending.</returns>
        SendEmailRequest CreateEmailMessage(EmailMessage email);
    }
}
