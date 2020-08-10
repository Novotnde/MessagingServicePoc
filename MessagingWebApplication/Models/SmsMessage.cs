using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingWebApplication.Models
{
    public class SmsMessage
    {
        public int Id { get; set; }

        [Required]
        public string Sender { get; set; }

        [Required]
        public string Reciever { get; set; }

        [Required]
        public string Body { get; set; }
    }
}
