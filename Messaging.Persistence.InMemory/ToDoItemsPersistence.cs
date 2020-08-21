using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Messaging_Persistence.Contracts.Contracts;
using Messaging_Persistence.Contracts.Entities;
using Microsoft.Extensions.Caching.Memory;

namespace Messaging.Persistence.InMemory
{
    class ToDoItemsPersistence : IToDoItemsPersistence
    {
        private readonly IMemoryCache _cache;

        public ToDoItemsPersistence(IMemoryCache memoryCache)
        {
            _cache = memoryCache;
        }
        public Task<ToDoItemsDto> GetToDoItemsAsync(int id)
        {
            var result = _cache.Get<ToDoItemsDto>(id);

            return Task.FromResult(result);
        }

        public Task SaveToDoItemAsync(ToDoItemsDto toDoItemsDto)
        {
            _cache.Set<ToDoItemsDto>(toDoItemsDto.Id, toDoItemsDto);

            return Task.CompletedTask;
        }
    }
}
