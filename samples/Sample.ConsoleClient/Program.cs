using Core.MessageSender.Contracts.Models;
using Core.MessageSender.Twilio;
using Microsoft.Extensions.Configuration;
using Poc_MessagingService.Constants;
using Twilio;

namespace Poc_MessagingService
{
    class Program
    {
        static void Main(string[] args)
        {
            TwilioSenderExtensions.InitTwilioClient(AppConstants.AccountSid, AppConstants.AuthToken);

            var messageSender = new TwilioMessageSender();
            var message = new Message()
            {
                Body = "test",
                Sender = "+12057827167",
                Reciever = "+420777894931"
            };

            var result = messageSender.Send(message);
        }
    }
}
