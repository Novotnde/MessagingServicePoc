using System;
using System.Collections.Generic;
using System.Text;
using Messaging_Persistence.Contracts.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Messaging.Persistence.InMemory
{
    public static class InMemoryPersistanceExtension
    {
        public static IServiceCollection AddInMemoryPersitence(this IServiceCollection services)
        {
            services.AddTransient<IToDoItemsPersistence, ToDoItemsPersistence>();

            return services;
        }
    }
}
