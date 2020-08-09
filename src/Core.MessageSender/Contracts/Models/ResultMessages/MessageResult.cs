using System;
using System.Collections.Generic;
using System.Text;
using Core.MessageSender.Contracts.Enums;

namespace Core.MessageSender.Contracts.Models
{
    public class MessageResult
    {
        public MessageStatus Status { get; set; }

        public string ErrorMessage { get; set; }
    }
}
