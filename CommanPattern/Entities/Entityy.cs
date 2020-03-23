using System;
using System.Collections.Generic;
using System.Text;

namespace CommanPattern
{
    public class Entity : IEntity
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
