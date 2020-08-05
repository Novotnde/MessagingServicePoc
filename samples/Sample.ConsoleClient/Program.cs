using System;
using System.IO;
using Core.MessageSender.Contracts.Models;
using Core.MessageSender.Twilio;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using Twilio;

namespace Poc_MessagingService
{
    class Program
    {
        /// <summary>
        /// Main entry point of the testing application
        /// </summary>
        /// <param name="args">Application arguments</param>
        static void Main(string[] args)
        {
            GetAuthentificationDetails();
            var messageSender = new TwilioMessageSender();
            var message = new Message()
            {
                Body = "test",
                Sender = "+12057827167",
                Reciever = "+420777894931"
            };

            var result = messageSender.Send(message);
        }

        /// <summary>
        /// Used for Twilio Authentification
        /// </summary>
        private static void GetAuthentificationDetails()
        {
            var myJsonString = File.ReadAllText("msgSettings.json");
            var myJObject = JObject.Parse(myJsonString);
            var accountSid = myJObject.SelectToken("AccountSID").Value<string>();
            var authToken = myJObject.SelectToken("AuthToken").Value<string>();
            TwilioSenderExtensions.InitTwilioClient(accountSid, authToken);
        }
    }
}
