namespace WinterIsComing.Models.CombatHandlers
{
    using System.Collections.Generic;
    using System.Linq;

    using Contracts;
    using Spells;

    using Core;
    using Core.Exceptions;

    public class IceGiantCombatHandler : CombatHandler
    {
        public override IEnumerable<IUnit> PickNextTargets(IEnumerable<IUnit> candidateTargets)
        {
            return this.Unit.HealthPoints <= 150 ? candidateTargets.Take(1) : candidateTargets;
        }

        public override ISpell GenerateAttack()
        {
            
            var damage = this.Unit.AttackPoints;
            this.Unit.AttackPoints += 5;
            var spell = new Stomp(damage);

            if (this.Unit.EnergyPoints < spell.EnergyCost)
            {
                throw new NotEnoughEnergyException(string.Format(GlobalMessages.NotEnoughEnergy, this.Unit.Name, spell.GetType().Name));
            }

            this.Unit.EnergyPoints -= spell.EnergyCost;

            return spell;
        }
    }
}
