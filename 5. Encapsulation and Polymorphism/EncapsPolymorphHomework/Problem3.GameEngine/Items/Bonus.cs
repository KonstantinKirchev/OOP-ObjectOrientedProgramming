using Problem3.GameEngine.Interfaces;

namespace Problem3.GameEngine.Items
{
    public abstract class Bonus : Item, ITimeoutable
    {
        protected Bonus(string id, int healthEffect, int defenseEffect, int attackEffect)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
        }

        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}
