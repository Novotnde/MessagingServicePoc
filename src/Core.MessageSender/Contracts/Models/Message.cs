using System;
using System.Collections.Generic;
using System.Text;

namespace Core.MessageSender.Contracts.Models
{
   public class Message
   {
        public string Sender { get; set; }

        public string Reciever { get; set; }

        public string Body { get; set; }
   }
}
