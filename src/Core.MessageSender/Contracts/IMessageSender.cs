using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.MessageSender.Contracts.Models;

namespace Core.MessageSender.Contracts
{
    public interface IMessageSender
    {
        /// <summary>
        /// Sends <see cref="Message"/> asynchronously.
        /// </summary>
        /// <param name="message">Message parameters.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation
        /// with <see cref="MessageResult"/> representing result of message sending.</returns>
        Task<MessageResult> SendAsync(Message message);

        /// <summary>
        /// Sends <see cref="Message"/> synchronously.
        /// </summary>
        /// <param name="message">Message parameters.</param>
        /// <returns><see cref="MessageResult"/> representing result of message sending.</returns>
        MessageResult Send(Message message);
    }
}
