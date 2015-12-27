namespace Problem3.GameEngine.Items
{
    public class Axe : Item
    {
        private const int HealthEffectAxe = 0;
        private const int DefenseEffectAxe = 0;
        private const int AttackEffectAxe = 75;

        public Axe(string id) 
            : base(id, HealthEffectAxe, DefenseEffectAxe, AttackEffectAxe)
        {
        }
    }
}
