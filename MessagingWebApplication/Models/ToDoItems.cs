using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingWebApplication.Models
{
    public class ToDoItems
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string DateAdded { get; set; }

        public string DateHappening { get; set; }

    }
}
