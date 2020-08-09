using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.MessageSender.Contracts.Models
{
    public class SendResponse
    {
        public string MessageId { get; set; }

        public List<string> ErrorMessages { get; set; }

        public bool Successful => !ErrorMessages.Any();

        public SendResponse()
        {
            ErrorMessages = new List<string>();
        }
    }

    public class SendResponse<T> : SendResponse
    {
        public T Data { get; set; }
    }
}
