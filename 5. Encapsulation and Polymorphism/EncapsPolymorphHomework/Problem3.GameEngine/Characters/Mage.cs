using System.Collections.Generic;
using System.Linq;
using Problem3.GameEngine.Items;

namespace Problem3.GameEngine.Characters
{
    public class Mage : AttackableCharacter
    {
        private const int HealthPointsMage = 150;
        private const int DefensePointsMage = 50;
        private const int AttackPointsMage = 300;
        private const int RangeMage = 5;

        public Mage(string id, int x, int y, Team team) 
            : base(id, x, y, HealthPointsMage, DefensePointsMage, team, RangeMage)
        {
            this.AttackPoints = AttackPointsMage;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            return targetsList.LastOrDefault(t => t.IsAlive && t.Team != this.Team);
        }
    }
}
