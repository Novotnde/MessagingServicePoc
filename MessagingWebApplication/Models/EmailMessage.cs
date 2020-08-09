using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingWebApplication.Models
{
    public class EmailMessage
    {
        public int Id { get; set; }

        public string Sender { get; set; }

        public string Reciever { get; set; }

        public string Body { get; set; }

        public string Subject { get; set; }
    }
}
