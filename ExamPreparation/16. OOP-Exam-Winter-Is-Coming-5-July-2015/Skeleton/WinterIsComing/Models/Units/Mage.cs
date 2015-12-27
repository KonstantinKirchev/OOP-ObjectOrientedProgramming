namespace WinterIsComing.Models.Units
{
    using CombatHandlers;

    public class Mage : Unit
    {
        private const int MageAttackPoints = 80;
        private const int MageHealthPoints = 80;
        private const int MageDefensePoints = 40;
        private const int MageEnergyPoints = 120;
        private const int MageRange = 2;

        public Mage(int x, int y, string name)
            : base(x, y, name, MageRange, MageAttackPoints, MageHealthPoints,
                  MageDefensePoints, MageEnergyPoints, new MageCombatHandler())
        {
        }
    }
}
