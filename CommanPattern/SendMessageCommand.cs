using System;
using System.Collections.Generic;
using System.Text;

namespace CommanPattern
{
    class SendMessageCommand : Command
    {
        private readonly IEntity _entity;
        public SendMessageCommand(IEntity entity):base(entity)
        {
            _entity = entity;
        }
        public override void Execute()
        {
            _entity.SendMessage("Hello world...");
        }
    }
}
