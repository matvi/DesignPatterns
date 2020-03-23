using System;
using System.Collections.Generic;
using System.Text;

namespace CommanPattern
{
    public abstract class Command
    {
        private readonly IEntity _entity;
        public Command(IEntity entity)
        {
            _entity = entity;
        }

        public abstract void Execute();

    }
}
