using System;
using Defenders;

namespace Enemies
{
    class Skeleton : Enemy
    {

        public Skeleton(string name, int hp) : base(name, hp)
        {
        }
        public override void GotAttackedBy(IDefender Def) 
        {
            GetDamage(Def.Attack(this));
        }
    }
}