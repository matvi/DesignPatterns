﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommandAPI.Data
{
   public  interface ICommandDispatcher
    {
        Task DispatchAsync<T>(T command) where T : ICommand;
    }

}
