using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class HelmetDecorator : EnemyDocorator
    {
        public HelmetDecorator(Enemy enemy) : base(enemy)
        {
            
        }

        public override int TakeDamage()
        {
            return base.TakeDamage() - 3;
        }
    }
}
