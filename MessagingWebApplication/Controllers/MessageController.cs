using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.MessageSender.Contracts;
using Core.MessageSender.Contracts.Models;
using MessagingWebApplication.Models;
using MessagingWebApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MessagingWebApplication.Controllers
{
    public class MessageController : Controller
    {
        private ApplicationDbContext _context;

        private IMessageSender _messageSender;
        public MessageController(IMessageSender messageSender)
        {
            this._messageSender = messageSender;
            _context = new ApplicationDbContext();
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
        public ActionResult Send(Message message)
        {
            var viewModel = new MessageViewModel
            {
                Message = new Message(),
             };
             _context.SaveChanges();
             _messageSender.Send(message);
            return View("MessageStatus", viewModel);
        }
    }
}
