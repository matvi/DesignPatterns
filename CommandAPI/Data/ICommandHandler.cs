using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Data
{
    public interface ICommandHandler<in T> where T : ICommand
    {
        Task HandleAsync(T command);
    }
}
