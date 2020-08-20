using System;
using System.Diagnostics;
using Core.MessageSender.Contracts;
using Core.MessageSender.Contracts.Models;
using MessagingWebApplication.Models;
using MessagingWebApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MessagingWebApplication.Controllers
{
    public class MessageController : Controller
    {
        private ApplicationDbContext _context;

        private IMessageSender _messageSender;
        public MessageController(IMessageSender messageSender, ApplicationDbContext context)
        {
            this._messageSender = messageSender;
            this._context = context;
        }

        public ActionResult Sms()
        {
            return View();
        }

        public ActionResult Email()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [ActionName("MessageStatus")]
        public ActionResult SendAsync(Message message)
        {
            var viewModel = new MessageViewModel
            {
                Message = new Message()
                {
                    
                }
                
            };
            _context.Messages.Add(message);
            _context.SaveChanges();
            _messageSender.SendAsync(message);
            return View("MessageStatus", viewModel);
        }
    }
}
