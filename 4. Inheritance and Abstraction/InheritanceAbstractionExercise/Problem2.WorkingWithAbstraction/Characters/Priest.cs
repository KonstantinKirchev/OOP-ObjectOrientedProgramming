using System;
using Problem2.WorkingWithAbstraction.Interfaces;

namespace Problem2.WorkingWithAbstraction.Characters
{
    public class Priest : Character, IHeal
    {
        private const int PriestHealth = 125;
        private const int PriestMana = 200;
        private const int PriestDamage = 100;

        public Priest() 
            : base(PriestHealth, PriestMana, PriestDamage)
        {
        }

        public override void Attack(Character target)
        {
            this.Mana -= 100;
            target.Health -= this.Damage;
            Health += this.Damage / 10;
        }

        public void Heal(Character target)
        {
            this.Mana -= 100;
            target.Health += 150;
        }
    }
}
