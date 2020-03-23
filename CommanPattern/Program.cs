
using CommanPattern.Entity;
using System;
using System.Collections.Generic;

namespace CommanPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var entity = new Message();
            var sendMessageCommand = new SendMessageCommand(entity);
            var sendEmailCommand = new SendEmailCommand(entity);

            //1 to execute multiple commands
            var commandProcesor = new CommandProcessor();
            commandProcesor.SetCommand(sendMessageCommand);
            commandProcesor.SetCommand(sendEmailCommand);
            commandProcesor.ExecuteCommands();


            //2 to execute command at the moment
            var commandProcesor2 = new CommandProcessor(sendEmailCommand);
            commandProcesor2 = new CommandProcessor(sendMessageCommand);


            //3 to execute commands without going through the CommandProccesor which is the Invoker
            // this is not part of the command pattern because it is not using the Invoker anymore
            var commands = new List<Command>
            {
                sendMessageCommand,
                sendEmailCommand
            };
            commands.ForEach(comand =>
            {
                comand.Execute();
            });


        }
    }
}
