namespace Exam.Interfaces
{
    using System.Collections.Generic;

    using Exam.Models.Interfaces;

    public interface IIsisData
    {
        IEnumerable<IMilitantGroup> MilitantGroups { get; }

        void AddMilitantGroup(IMilitantGroup militantGroup);
    }
}
