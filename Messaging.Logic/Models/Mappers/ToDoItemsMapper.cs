using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Messaging_Persistence.Contracts.Entities;

namespace Messaging.Logic.Models
{
   public static class ToDoItemsMapper
   {
        internal static ToDoItem FromDto(this ToDoItemsDto toDoItemDto)
        {
            var toDoItem = new ToDoItem
            {
                Id = toDoItemDto.Id,
                Title = toDoItemDto.Title,
                Body = toDoItemDto.Body,
                DateAdded = toDoItemDto.DateAdded,
                DateHappening = toDoItemDto.DateHappening,
            };

            return toDoItem;
        }

        internal static ToDoItemsDto ToDto(this ToDoItem toDoItem)
        {
            return new ToDoItemsDto
            {
                Id = toDoItem.Id,
                Title = toDoItem.Title,
                Body = toDoItem.Body,
                DateAdded = toDoItem.DateAdded,
                DateHappening = toDoItem.DateHappening,
            };
        }
    }
}
