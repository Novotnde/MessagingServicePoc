using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.MessageSender.Contracts.Models;
using MessagingWebApplication.Models;

namespace MessagingWebApplication.ViewModel
{
    public class MessageViewModel
    {
        public Message Message {get; set;}
        public SmsMessage SmsMessage { get; set; }
    }
}
