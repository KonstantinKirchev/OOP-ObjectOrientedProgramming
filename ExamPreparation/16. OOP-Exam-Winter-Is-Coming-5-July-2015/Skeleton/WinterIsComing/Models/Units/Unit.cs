namespace WinterIsComing.Models.Units
{
    using System;
    using System.Text;

    using WinterIsComing.Contracts;

    public abstract class Unit : IUnit
    {
        private int x;
        private int y;
        private string name;
        private int range;
        private int attackPoints;
        private int healthPoints;
        private int defensePoints;
        private int energyPoints;
        protected ICombatHandler combatHandler;

        protected Unit(int x, int y, string name, int range, int attackPoints, int healthPoints, 
            int defensePoints, int energyPoints, ICombatHandler combatHandler)
        {
            this.X = x;
            this.Y = y;
            this.Name = name;
            this.Range = range;
            this.AttackPoints = attackPoints;
            this.HealthPoints = healthPoints;
            this.DefensePoints = defensePoints;
            this.EnergyPoints = energyPoints;
            this.CombatHandler = combatHandler;
            this.CombatHandler.Unit = this;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public string Name { get; }

        public int Range { get; }

        public int AttackPoints { get; set; }

        public int HealthPoints { get; set; }

        public int DefensePoints { get; set; }

        public int EnergyPoints { get; set; }

        public ICombatHandler CombatHandler
        {
            get { return this.combatHandler; }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Combat handler cannot be null");
                }

                this.combatHandler = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendFormat($">{this.Name} - {this.GetType().Name} at ({this.X},{this.Y}){Environment.NewLine}");

            if (this.HealthPoints > 0)
            {
                
                output.AppendFormat($"-Health points = {this.HealthPoints}{Environment.NewLine}");
                output.AppendFormat($"-Attack points = {this.AttackPoints}{Environment.NewLine}");
                output.AppendFormat($"-Defense points = {this.DefensePoints}{Environment.NewLine}");
                output.AppendFormat($"-Energy points = {this.EnergyPoints}{Environment.NewLine}");
                output.AppendFormat($"-Range = {this.Range}");
            }
            else
            {
                output.Append("(Dead)");
            }

            return output.ToString();
        }
    }
}
