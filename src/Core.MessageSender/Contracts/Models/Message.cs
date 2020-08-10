using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.MessageSender.Contracts.Models
{
   public class Message
    {
        public int Id { get; set; }

        [Key]
        [Required]
        public string Sender { get; set; }

        [Required]
        public string Reciever { get; set; }

        [Required]
        public string Body { get; set; }

        public string MessageSid { get; }

    }
}
