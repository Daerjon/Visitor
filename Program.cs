using System;
using System.Collections.Generic;
using Defenders;
using Enemies;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var enemies = new List<Enemy>()
            {
                new Orc("Borg", 60, 5),
                new Orc("Gorg", 10, 5),
                new Orc("Dorg", 20, 1),
                new Orc("Worg", 30, 3),
                new Skeleton("Skelly", 50),
                new Skeleton("Boney", 32),
                new Elemental("Smokey", 15, 10),
                new Elemental("Lightning", 7, 10),
                new Elemental("Sparky", 11, 10),
                new Elemental("Flowly", 1, 90),
            };


            var defenders = new List<IDefender>()
            {
                new Mage("Bolter", 0, 100, 1000),
                new Warrior("Smitter", 8),
                new Archer("Scooter", 10, 7),
                new Mage("Merlin", 15, 2, 10),
                new Archer("Legolans", 10, 9),
                new Warrior("Drav", 3),
                new FireMage("Dark Caster", 10, 0, 1, 10),
            };

            foreach (var enemy in enemies)
                Attack(enemy, defenders);
        }

        static void Attack(Enemy enemy, IEnumerable<IDefender> defenders)
        {
            foreach (var defender in defenders)
            {
                enemy.GotAttackedBy(defender);
                if (!enemy.Alive)
                    break;
            }


            if (enemy.Alive)
                Console.WriteLine($"{enemy.Name} is alive!");

            Console.WriteLine(string.Empty);
        }
    }
}
