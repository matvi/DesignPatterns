using System;

namespace DecoratorPattern
{
    class Program
    {
        /*
         * The decorator pattern allows us to add dynamic functionality to our existing object.
         * This functionality is added in layers where the order is important because you will apply the filters in the result of the layer above the other
         * 
         * The decorator pattern avoids the necessity of creating different classes to implement different functionality.
         * For example withouth the decorator pattern you will need to implement a different class for each functionality
         * 1 EnemyWithShield
         * 2 EnemyWithHelmet
         * 3 EnemyWithArmour
         * 4 EnemyWithShieldAndHelmet
         * 5 EnemyWithShieldAndArmour
         * 6 EnemyWithSieldAndArmourAndHelmet
         * 7 EnemyWithHelmetAndArmour
         * 
         * This code can get big really quick and hard to maintain
         * 
         * The uses of decorator pattern avoids this by creating functionality on top allowing to add them in layers.
         * */
        static void Main(string[] args)
        {
            var enemy = new BaseEnemy();

            var computedDamaged = enemy.TakeDamage();

            var enemyWithHelmet = new HelmetDecorator(enemy);

            var damagedWithHelmet = enemyWithHelmet.TakeDamage();

            var enemyWithHelmetAndArmour = new ArmourDecorator(enemyWithHelmet);

            var damagedWithHelmetAndArmour = enemyWithHelmetAndArmour.TakeDamage();


            Console.WriteLine($"Normal damage : {computedDamaged}");
            Console.WriteLine($"Damage with helmet: {damagedWithHelmet}");
            Console.WriteLine($"Damage with Armour and Helmet: {damagedWithHelmetAndArmour}");
        }
    }
}
