using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Messaging.Logic.Models;

namespace Messaging.Logic.Contracts
{
    public interface IToDoItemService
    {
        Task<ToDoItem> GetToDoItemsAsync(int id);

        Task SaveToDoItemAsync(ToDoItem toDoItems);
    }
}
