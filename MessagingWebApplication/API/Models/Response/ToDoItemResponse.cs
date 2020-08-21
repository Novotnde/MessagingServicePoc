using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessagingWebApplication.API.Models.Response
{
    public class ToDoItemResponse
    {
        public ToDoItemResponse(int id, string title, string body, string dateAdded, string dateHappening)
        {
            Id = id;
            Title = title;
            Body = body;
            DateAdded = dateAdded;
            DateHappening = dateHappening;
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public string DateAdded { get; set; }

        public string DateHappening { get; set; }
    }
}
