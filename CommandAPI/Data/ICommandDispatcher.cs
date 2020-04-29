using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Data
{
   public  interface ICommandDispatcher
    {
        Task<TResponse> DispatchAsync<T,TResponse>(T command) where T : ICommand where TResponse:IResponse;
    }

}
