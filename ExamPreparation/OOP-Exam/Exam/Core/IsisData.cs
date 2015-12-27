namespace Exam.Core
{
    using System;
    using System.Collections.Generic;
    using Exam.Models.Interfaces;
    using Interfaces;

    public class IsisData : IIsisData
    {
        private readonly ICollection<IMilitantGroup> militantGroups;

        public IsisData()
        {
            this.militantGroups = new List<IMilitantGroup>();
        }

        public IEnumerable<IMilitantGroup> MilitantGroups => this.militantGroups;

        public void AddMilitantGroup(IMilitantGroup militantGroup)
        {
            if (militantGroup == null)
            {
                throw new ArgumentNullException(nameof(militantGroup));
            }

            this.militantGroups.Add(militantGroup);
        }
    }
}
