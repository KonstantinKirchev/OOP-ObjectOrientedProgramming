namespace Exam.Core.Factories
{
    using Models;
    using Models.Enums;
    using Models.Interfaces;

    using Interfaces;

    public class MilitantGroupFactory : IMilitantGroupFactory
    {
        public IMilitantGroup CreateMilitantGroup(string name, int health, int damage, WarEffect warEffect, AttackType attackType)
        {
            return new MilitantGroup(name, health, damage, warEffect, attackType);
        }
    }
}
