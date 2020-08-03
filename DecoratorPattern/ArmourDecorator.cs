using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class ArmourDecorator : EnemyDocorator
    {
        public ArmourDecorator(Enemy enemy) : base(enemy)
        {
        }

        public override int TakeDamage()
        {
            return base.TakeDamage() / 2;
        }
    }
}
