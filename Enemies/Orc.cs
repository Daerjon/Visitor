using System;
using Defenders;

namespace Enemies
{
    class Orc : Enemy
    {
        public int Armor { get; }

        public Orc(string name, int hp, int armor) : base(name, hp)
        {
            Armor = armor;
        }
        public override void GotAttackedBy(IDefender Def)
        {
            GetDamage(Def.Attack(this));
        }
    }
}