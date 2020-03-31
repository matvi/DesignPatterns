using System;
using System.Collections.Generic;
using System.Text;

namespace CommanPattern
{
   public class CommandProcessor
    {
        private List<Command> _commands = new List<Command>();

        public CommandProcessor()
        {

        }
        public CommandProcessor(Command command)
        {
            command.Execute();
        }

        public void SetCommand(Command command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            _commands.ForEach(command =>
            {
                command.Execute();
            });
        }
    }
}
