using Core.MessageSender.Contracts.Models;


namespace MessagingWebApplication.ViewModel
{
    public class MessageViewModel
    {
        public Message Message {get; set;}
        public EmailMessage EmailMessage { get; set; }
    }
}
