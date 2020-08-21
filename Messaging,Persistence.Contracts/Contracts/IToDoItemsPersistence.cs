using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Messaging_Persistence.Contracts.Entities;

namespace Messaging_Persistence.Contracts.Contracts
{
    public interface IToDoItemsPersistence
    {
        Task<ToDoItemsDto> GetToDoItemsAsync(int id);

        Task SaveToDoItemAsync(ToDoItemsDto toDoItemsDto);
    }
}
