using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class BaseEnemy : Enemy
    {
        public int TakeDamage()
        {
            return 10;
        }
    }
}
