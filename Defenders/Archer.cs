using System;
using Enemies;

namespace Defenders
{
    class Archer : Warrior
    {
        private int arrows;

        public Archer(string name, int strength, int arrows) : base(name, strength)
        {
            this.arrows = arrows;
        }

        public override int Attack(Skeleton enemy)
        {
            if (arrows == 0)
            {
                Console.WriteLine($"{name} tries to multishoot, but had forgot he's out of arrows");
                return 0;
            }
            if (arrows == 1)
            {
                arrows = 0;
                Console.WriteLine($"{name} tries to double-shot, but with only one arrow he deals {strength} damage to {enemy.Name}");
                return strength;
            }
            arrows -= 2;
            Console.WriteLine($"{name} succeeds in shooting two arrows at once, dealing {2*strength} damage to {enemy.Name}");
            return 2*strength;
        }

        public override int Attack(Orc enemy)
        {
            if (arrows == 0)
            {
                Console.WriteLine($"{name} reminded himself his quiver is empty");
                return 0;
            }
            arrows--;
            int dmg = strength - enemy.Armor < 1 ? 1 : strength - enemy.Armor;
            Console.WriteLine($"{name} deals {dmg} damage to {enemy.Name} by shooting his knee");
            return dmg;
        }

        public override int Attack(Elemental enemy)
        {
            if (arrows == 0)
            {
                Console.WriteLine($"{name} needs more arrows");
                return 0;
            }
            arrows--;
            Console.WriteLine($"{name}'s arrow passed though {enemy.Name}");
            return strength;
        }
    }
}