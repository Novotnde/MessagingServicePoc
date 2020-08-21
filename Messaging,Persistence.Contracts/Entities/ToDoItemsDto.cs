using System;
using System.Collections.Generic;
using System.Text;

namespace Messaging_Persistence.Contracts.Entities
{
    public class ToDoItemsDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string DateAdded { get; set; }

        public string DateHappening { get; set; }
    }
}
