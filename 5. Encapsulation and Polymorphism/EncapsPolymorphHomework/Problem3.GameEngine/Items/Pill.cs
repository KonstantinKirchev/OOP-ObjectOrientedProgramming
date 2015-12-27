namespace Problem3.GameEngine.Items
{
    public class Pill : Bonus
    {
        private const int HealthEffectPill = 0;
        private const int DefenseEffectPill = 0;
        private const int AttackEffectPill = 100;
        private const int TimeOutTurns = 1;

        public Pill(string id) 
            : base(id, HealthEffectPill, DefenseEffectPill, AttackEffectPill)
        {
            this.Timeout = TimeOutTurns;
            this.Countdown = TimeOutTurns;
        }
    }
}
