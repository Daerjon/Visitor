using System;
using Enemies;

namespace Defenders
{
    class Warrior : IDefender
    {
        protected readonly string name;
        protected readonly int strength;
        protected static readonly Random rng = new Random(1597);

        public Warrior(string name, int strength)
        {
            this.name = name;
            this.strength = strength;
        }

        public virtual int Attack(Skeleton enemy)
        {
            Console.WriteLine($"{name} swings his axe to deal {strength} damage to {enemy.Name}");
            return strength;
        }

        public virtual int Attack(Orc enemy)
        {
            int dmg = strength - enemy.Armor < 1 ? 1 : strength - enemy.Armor;
            Console.WriteLine($"{name} swings his great warhammer to deal {dmg} damage to {enemy.Name}");
            return dmg;
        }

        public virtual int Attack(Elemental enemy)
        {
            Console.WriteLine($"{name} swords passed through {enemy.Name}");
            return 0;
        }
    }
}