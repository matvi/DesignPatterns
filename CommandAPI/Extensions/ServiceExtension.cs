using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Extensions
{
    using Microsoft.Extensions.DependencyInjection;

    public static class ServiceExtension
    {
        public static void AddCommandQueryHandlers(this IServiceCollection services, Type handlerInterface)
        {
            var handlers = typeof(Startup).Assembly.GetTypes()
                .Where(t => t.GetInterfaces().Any(i => i.IsGenericType && i.GetGenericTypeDefinition() == handlerInterface)
                );

            foreach (var handler in handlers)
            {
                services.AddScoped(handler.GetInterfaces().First(i => i.IsGenericType && i.GetGenericTypeDefinition() == handlerInterface), handler);
            }
        }
    }
}
