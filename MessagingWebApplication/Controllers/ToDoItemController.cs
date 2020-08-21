using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Amazon.SimpleEmail.Model;
using MessagingWebApplication.Models;
using MessagingWebApplication.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace MessagingWebApplication.Controllers
{
    public class ToDoItemController : Controller
    {
        private ApplicationDbContext _context;

        public ToDoItemController( ApplicationDbContext context)
        {
            this._context = context;
        }

        public ActionResult ToDoItem()
        {
            return View();
        }

        public ActionResult ToDoItemSummary()
        {
            var todo = _context.ToDoItems.ToList().OrderByDescending(t=>t.DateAdded);

            return View(todo);
        }

        public ActionResult Details(int id)
        {
            var todo = _context.ToDoItems.SingleOrDefault(t => t.Id == id);

            return View(todo);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [ActionName("MessageStatus")]
        public async Task<ActionResult> SaveAsync(ToDoItems toDoItems)
        {

            var viewModel = new ToDoItemsViewModel
            {
                ToDoItems = new ToDoItems()
                {
                    DateAdded = DateTime.Today.ToShortTimeString(),
                },
            };
            await _context.ToDoItems.AddAsync(toDoItems);
            await _context.SaveChangesAsync();
         
            return View("ToDoItemSummary", viewModel);
        }
    }
}
