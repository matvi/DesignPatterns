using System;
using System.Collections.Generic;
using System.Text;

namespace CommanPattern
{
    public class SendEmailCommand: Command
    {
        private readonly IEntity _entity;
        public SendEmailCommand(IEntity entity): base(entity)
        {
            _entity = entity;
        }

        public override void Execute()
        {
            _entity.SendMessage("Sending message by email");
        }
    }
}
