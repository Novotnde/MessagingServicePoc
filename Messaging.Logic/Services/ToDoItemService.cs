using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Messaging.Logic.Contracts;
using Messaging.Logic.Models;
using Messaging_Persistence.Contracts.Contracts;

namespace Messaging.Logic.Services
{
    public class ToDoItemService : IToDoItemService
    {
        private readonly IToDoItemsPersistence _toDoItemsPersistence;

        public ToDoItemService(IToDoItemsPersistence toDoItemsPersistence)
        {
            _toDoItemsPersistence = toDoItemsPersistence;
        }
        public async Task<ToDoItem> GetToDoItemsAsync(int id)
        {
            var result = await _toDoItemsPersistence.GetToDoItemsAsync(id);

            return result.FromDto();
        }

        public Task SaveToDoItemAsync(ToDoItem toDoItems)
        {
            return _toDoItemsPersistence.SaveToDoItemAsync(toDoItems.ToDto());
        }
    }
}
