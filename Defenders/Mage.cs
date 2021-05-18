using System;
using Enemies;

namespace Defenders
{
    class Mage : IDefender
    {
        protected readonly string name;
        protected int mana;
        protected readonly int manaRegen;
        protected readonly int spellPower;

        public Mage(string name, int mana, int manaRegen, int spellPower)
        {
            this.name = name;
            this.mana = mana;
            this.manaRegen = manaRegen;
            this.spellPower = spellPower;
        }

        protected bool CanCastSpell()
        {
            if (mana >= spellPower)
            {
                mana -= spellPower;
                return true;
            }
            Console.WriteLine($"{name} is recharging mana");
            RechargeMana();
            return false;
        }

        private void RechargeMana()
        {
            mana += manaRegen;
        }

        public virtual int Attack(Skeleton enemy)
        {
            if (CanCastSpell())
            {
                Console.WriteLine($"{name} uses ancient magic to deal {spellPower} damage to {enemy.Name}");
                return spellPower;
            }
            return 0;
        }

        public virtual int Attack(Orc enemy)
        {
            if (CanCastSpell())
            {
                Console.WriteLine($"{name} shapes magic around him to deal {spellPower} damage to {enemy.Name}");
                return spellPower;
            }
            return 0;
        }

        public virtual int Attack(Elemental enemy)
        {
            if (CanCastSpell())
            {
                int dmg = spellPower - enemy.MagicResist < 1 ? 1 : spellPower - enemy.MagicResist;
                Console.WriteLine($"{name} empowers his next shoot to deal {dmg} damage to {enemy.Name}");
                return dmg;
            }
            return 0;
        }
    }
}