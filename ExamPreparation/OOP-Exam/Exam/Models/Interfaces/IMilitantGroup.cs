namespace Exam.Models.Interfaces
{
    public interface IMilitantGroup : IAttacker, IDestroyable, IWarEffect, IAttackType
    {
        string Name { get; }
    }
}
