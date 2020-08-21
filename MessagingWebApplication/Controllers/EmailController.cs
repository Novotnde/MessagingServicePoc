using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Core.MessageSender.Contracts;
using Core.MessageSender.Contracts.Models;
using MessagingWebApplication.Models;
using MessagingWebApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MessagingWebApplication.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private ApplicationDbContext _context;

        private IEmailSender _messageSender;
        public EmailController(IEmailSender messageSender, ApplicationDbContext context)
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
        public async Task<ActionResult> SendAsync(EmailMessage message)
        {
            var viewModel = new MessageViewModel
            {
                Message = new EmailMessage()
                {

                }

            };
            await _context.EmailMessages.AddAsync(message);
            await _context.SaveChangesAsync();
            await _messageSender.SendAsync(message);
            return View("MessageStatus", viewModel);
        }
    }
}
