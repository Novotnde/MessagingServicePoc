using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.MessageSender.Contracts.Models;

namespace Core.MessageSender.Contracts
{
    public interface IMessageSender
    {
        Task<MessageResult> SendAsync(Message message);

        MessageResult Send(Message message);
    }
}
