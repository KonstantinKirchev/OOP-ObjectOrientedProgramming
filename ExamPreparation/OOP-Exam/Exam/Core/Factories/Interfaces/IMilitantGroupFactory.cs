namespace Exam.Core.Factories.Interfaces
{
    using Models.Enums;

    using Models.Interfaces;

    public interface IMilitantGroupFactory
    {
        IMilitantGroup CreateMilitantGroup(string name, int health, int damage, WarEffect warEffect, AttackType attackType);
    }
}
