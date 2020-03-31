using System;
using System.Collections.Generic;
using System.Text;

namespace ICommandYou.Command
{
    using System.Threading.Tasks;
    /// <summary>
    /// This dispatches the commands automatically (to the appropriate instance of the ICommandHandler)
    /// </summary>
    public interface ICommandDispatcher
    {
        Task DispatchAsync<T>(T command)
            where T : ICommand;
    }
}
