using System;
using System.Collections.Generic;
using System.Text;
using Messaging.Logic.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace Messaging.Logic.Services
{
    public static class LogicExtension
    {
        public static IServiceCollection AddLogicServices(this IServiceCollection services)
        {
            services.AddTransient<IToDoItemService, ToDoItemService>();

            return services;
        }
    }
}
