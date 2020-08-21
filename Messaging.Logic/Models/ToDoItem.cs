using System;
using System.Collections.Generic;
using System.Text;

namespace Messaging.Logic.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string DateAdded { get; set; }

        public string DateHappening { get; set; }

    }
}
