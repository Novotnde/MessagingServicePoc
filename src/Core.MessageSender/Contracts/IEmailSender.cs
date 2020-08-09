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
        Task<SendResponse> SendAsync(EmailMessage email);

        SendResponse Send(EmailMessage email);

        SendEmailRequest CreateEmailMessage(EmailMessage email);
    }
}
