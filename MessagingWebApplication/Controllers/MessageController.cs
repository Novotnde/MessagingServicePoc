using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.MessageSender.Contracts;
using MessagingWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MessagingWebApplication.Controllers
{
    public class MessageController : Controller
    {
    //    private IMessageSender _messageSender;

    //    public MessageController(IMessageSender messageSender)
    //    {
    //        this._messageSender = messageSender;
    //    }
        public IActionResult Sms()
        {
            
            return View();
        }

        public IActionResult Email()
        {

            return View();
        }

        private readonly ILogger<MessageController> _logger;

        public MessageController(ILogger<MessageController> logger)
        {
            _logger = logger;
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
