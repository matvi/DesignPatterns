using System;
using System.Collections.Generic;
using System.Text;

namespace ICommandYou.Command
{
    using System.Threading.Tasks;

    public class CommandDispatcher : ICommandDispatcher
    {
        private readonly IComponentContext _context;

        public CommandDispatcher(IComponentContext context)
        {
            _context = context;
        }
        public async Task DispatchAsync<T>(T command)
            where T : ICommand
        {

            if (command == null)
            {
                throw new ArgumentNullException(nameof(command), "Command can´t be null");
            }

            var handler = _context.Resolve<ICommandHandler<T>>();
            await handler.HandlerAsync(command);


        }
    }
}
