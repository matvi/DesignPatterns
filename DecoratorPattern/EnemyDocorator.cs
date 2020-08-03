using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class EnemyDocorator : Enemy
    {
        protected Enemy _enemy;

        public EnemyDocorator(Enemy enemy)
        {
            _enemy = enemy;
        }
        public virtual int TakeDamage()
        {
            return this._enemy.TakeDamage();
        }
    }
}
