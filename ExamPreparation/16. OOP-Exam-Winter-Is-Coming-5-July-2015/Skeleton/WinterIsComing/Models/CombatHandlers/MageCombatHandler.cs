namespace WinterIsComing.Models.CombatHandlers
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Spells;

    using Core.Exceptions;

    using WinterIsComing.Core;

    public class MageCombatHandler : CombatHandler
    {
        private bool isCast = false;

        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var targets = candidateTargets.OrderByDescending(c => c.HealthPoints).ThenBy(c => c.Name).Take(3);

            return targets;
        }

        public override ISpell GenerateAttack()
        {
            this.isCast = !this.isCast;

            if (this.isCast)
            {
                var damage = this.Unit.AttackPoints;
                var spell = new FireBreath(damage);

                if (this.Unit.EnergyPoints < spell.EnergyCost)
                {
                    this.isCast = !this.isCast;
                    throw new NotEnoughEnergyException(string.Format(GlobalMessages.NotEnoughEnergy, this.Unit.Name, spell.GetType().Name));
                }

                this.Unit.EnergyPoints -= spell.EnergyCost;

                return spell;
            }
            else
            {
                var damage = this.Unit.AttackPoints * 2;
                var spell = new Blizzard(damage);

                if (this.Unit.EnergyPoints < spell.EnergyCost)
                {
                    this.isCast = !this.isCast;
                    throw new NotEnoughEnergyException(string.Format(GlobalMessages.NotEnoughEnergy, this.Unit.Name, spell.GetType().Name));
                }

                this.Unit.EnergyPoints -= spell.EnergyCost;

                return spell;
            }
        }
    }
}
