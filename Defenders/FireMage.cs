using System;
using Enemies;

namespace Defenders
{
    class FireMage : Mage
    {
        private int MagicPenetration;
        protected static readonly Random rng = new Random(1597);

        public FireMage(string name, int mana, int manaRegen, int spellPower, int mpen) : base(name, mana, manaRegen, spellPower)
        {
            this.MagicPenetration = mpen;
        }

        public override int Attack(Skeleton enemy)
        {
            if (CanCastSpell())
            {
                Console.WriteLine($"{name} shoots fire bolt dealing {spellPower} damageto {enemy.Name}");
                return spellPower;
            }
            return 0;
        }

        public override int Attack(Orc enemy)
        {
 
            if (CanCastSpell())
            {
                Console.WriteLine($"{name} encloses {enemy.Name} in flaming vortex dealing {spellPower} damage");
                return spellPower;
            }
            return 0;
        }

        public override int Attack(Elemental enemy)
        {
            if (CanCastSpell())
            {
                int pen = (enemy.MagicResist - MagicPenetration < 0 ? 0 : enemy.MagicResist - MagicPenetration);
                int dmg = spellPower - pen < 1 ? 1 : spellPower - pen;
                Console.WriteLine($"{name} shows {enemy.Name} his new magic trick and deals {dmg} damage");
                return dmg;
            }
            return 0;
        }
    }
}