using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Data
{
    using CommandAPI.Handler;

    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IServiceProvider _serviceProvider;

        public CommandDispatcher(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        

        public async Task<TResponse> DispatchAsync<T, TResponse>(T command)
            where T : ICommand
            where TResponse : IResponse
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command),
                    "Command can not be null.");
            }

            var handler = _serviceProvider.GetService(typeof(ICommandHandler<T>)) as ICommandHandler<T>;
            var response = await handler.HandleAsync(command);
            return (TResponse)response;
        }
    }
}
