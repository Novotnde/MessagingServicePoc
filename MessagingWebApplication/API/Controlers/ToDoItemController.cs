using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Messaging.Logic.Contracts;
using Messaging.Logic.Models;
using MessagingWebApplication.API.Models.Request;
using MessagingWebApplication.API.Models.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MessagingWebApplication.API
{
    [ApiController]
    [Route("toDoItems")]
    public class ToDoItemController : ControllerBase
    {
        private readonly IToDoItemService _toDoItemService;

        public ToDoItemController(IToDoItemService toDoItemService)
        {
            _toDoItemService = toDoItemService;
        }

        [HttpGet("{id}")]
        public async Task<ToDoItemResponse> GetAsync(int id) 
        {
            var result = await _toDoItemService.GetToDoItemsAsync(id);

            return new ToDoItemResponse(result.Id, result.Title, result.Body, result.DateAdded, result.DateHappening);
        }

        [HttpPost]
        public Task Save([FromBody]ToDoItemRequest toDoItemRequest)
        {
            var todo = new ToDoItem
            {
                Id = toDoItemRequest.Id,
                Title = toDoItemRequest.Title,
                Body = toDoItemRequest.Body,
                DateAdded = toDoItemRequest.DateAdded,
                DateHappening = toDoItemRequest.DateHappening

            };

            return _toDoItemService.SaveToDoItemAsync(todo);
        }
    }
}
