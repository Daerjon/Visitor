using System;
using Defenders;

namespace Enemies
{
    class Elemental : Enemy
    {
        public int MagicResist { get; }

        public Elemental(string name, int hp, int mr) : base(name, hp)
        {
            MagicResist = mr;
        }

        public override void GotAttackedBy(IDefender Def)
        {
            GetDamage(Def.Attack(this));
        }
    }
}