namespace WinterIsComing.Models.CombatHandlers
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Spells;

    using WinterIsComing.Core;
    using WinterIsComing.Core.Exceptions;

    public class WarriorCombatHandler : CombatHandler
    {
        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            var target = candidateTargets.OrderBy(c => c.HealthPoints).ThenBy(c => c.Name).Take(1);

            return target;
        }

        public override ISpell GenerateAttack()
        {
            var damage = this.Unit.AttackPoints;

            if (this.Unit.HealthPoints <= 80)
            {
                damage += (this.Unit.HealthPoints * 2);
            }

            var spell = new Cleave(damage);

            if (this.Unit.HealthPoints > 50)
            {
                if (this.Unit.EnergyPoints < spell.EnergyCost)
                {
                    throw new NotEnoughEnergyException(string.Format(GlobalMessages.NotEnoughEnergy,this.Unit.Name,spell.GetType().Name));
                    throw new NotEnoughEnergyException($"{this.GetType().Name} does not have enough energy to cast {spell.GetType().Name}");
                }

                this.Unit.EnergyPoints -= spell.EnergyCost;
            }

            return spell;
        }
    }
}
