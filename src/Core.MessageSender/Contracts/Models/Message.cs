using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.MessageSender.Contracts.Models
{
   public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Required]
        public string Sender { get; set; }

        [Required]
        public string Reciever { get; set; }

        [Required]
        public string Body { get; set; }

   }
}
