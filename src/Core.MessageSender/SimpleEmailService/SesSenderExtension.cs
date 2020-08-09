using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using Amazon;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using Core.MessageSender.Contracts.Models;
using Newtonsoft.Json.Linq;

namespace Core.MessageSender.SimpleEmailService
{
    public static class SesSenderExtension
    {
        public static ClientAmazon JsonParse()
        {
            var myJsonString = File.ReadAllText("msgSettings.json");
            var myJObject = JObject.Parse(myJsonString);
            var client = new ClientAmazon()
            {
                AccessKeyID = myJObject.SelectToken("AccessKeyId").Value<string>(),
                SecretAccessKey = myJObject.SelectToken("SecretAccessKey").Value<string>()
            };
            return client;
        }

        public static AmazonSimpleEmailServiceClient GetClient(ClientAmazon client)
        {
            if (client is null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            return new AmazonSimpleEmailServiceClient(client.AccessKeyID, client.SecretAccessKey, Amazon.RegionEndpoint.EUCentral1);
        }
    }
}
