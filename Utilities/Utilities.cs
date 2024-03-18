using ToDoList.Interfaces;
using ToDoList.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ToDoList.Utilities
{
    public static class Utilities
    {
        public static void AddTask(this IServiceCollection services)
        {
            services.AddSingleton<ImyTaskService, myTaskService>();
        }
    }
}