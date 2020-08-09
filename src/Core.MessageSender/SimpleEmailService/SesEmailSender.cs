using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;

using Core.MessageSender.Contracts;
using Core.MessageSender.Contracts.Models;

namespace Core.MessageSender.SimpleEmailService
{
    public class SesEmailSender : IEmailSender
    {
        private readonly ClientAmazon _clientAmazon;

        public SesEmailSender(ClientAmazon clientAmazon)
        {
            _clientAmazon = clientAmazon;
        }

        public async Task<SendResponse> SendAsync(EmailMessage email)
        {
            var response = new SendResponse();
            var mailMessage = CreateEmailMessage(email);

            using (var client = SesSenderExtension.GetClient(_clientAmazon))
            {
                await client.SendEmailAsync(mailMessage).ConfigureAwait(false);
            }

            return response;
        }

        public SendResponse Send(EmailMessage email)
        {
            return SendAsync(email).GetAwaiter().GetResult();
        }

        public SendEmailRequest CreateEmailMessage(EmailMessage email)
        {
            if (email is null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            var sendRequest = new SendEmailRequest
            {
                Source = email.Sender,
                Destination = new Destination { ToAddresses = { email.Reciever } },
                Message = new Amazon.SimpleEmail.Model.Message
                {
                    Subject = new Content(email.Subject),
                    Body = new Body
                    {
                        Html = new Content(email.Body)
                    }
                }
            };
            return sendRequest;
        }
    }
}
