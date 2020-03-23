using System;
using System.Collections.Generic;
using System.Text;

namespace CommanPattern.Entity
{
    public class Message : IEntity
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
