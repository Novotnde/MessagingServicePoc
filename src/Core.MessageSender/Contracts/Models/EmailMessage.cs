using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Text;

namespace Core.MessageSender.Contracts.Models
{
    public class EmailMessage : Message
    {
        public string Subject { get; set; }
    }
}
