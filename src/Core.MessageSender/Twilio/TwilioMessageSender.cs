using System;
using System.Threading.Tasks;
using Core.MessageSender.Contracts;
using Core.MessageSender.Contracts.Enums;
using Core.MessageSender.Contracts.Models;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using static Twilio.Rest.Api.V2010.Account.Call.FeedbackSummaryResource;

namespace Core.MessageSender.Twilio
{
    public class TwilioMessageSender : IMessageSender
    {
        public MessageResult Send(Message message)
        {
            if (message is null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            var msg = MessageResource.Create(
               body: message.Body,
               from: new PhoneNumber(message.Sender),
               to: new PhoneNumber(message.Reciever));
            return MapMessageResult(msg);
        }

        public async Task<MessageResult> SendAsync(Message message)
        {
            if (message is null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            var msg = await MessageResource.CreateAsync(
               body: message.Body,
               from: new PhoneNumber(message.Sender),
               to: new PhoneNumber(message.Reciever)).ConfigureAwait(false);

            return MapMessageResult(msg);
        }

        private MessageResult MapMessageResult(MessageResource messageResource)
        {
            if (messageResource.Status == StatusEnum.Failed)
            {
                return new MessageResult
                {
                    Status = MessageStatus.Failed,
                    ErrorMessage = messageResource.ErrorMessage
                };
            }

            return new MessageResult
            {
                Status = MessageStatus.Succeded
            };
        }
    }
}
