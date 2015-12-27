namespace Exam.Models
{
    using Enums;
    using Core;
    using Interfaces;

    public class MilitantGroup : IMilitantGroup
    {
        private string name;
        private int health;
        private int damage;
         
        public MilitantGroup(string name, int health, int damage, WarEffect warEffect, AttackType attackType)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
            this.WarEffect = warEffect;
            this.AttackType = attackType;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalMessages.StringCannotBeNullEmptyOrWhiteSpace, "Group name"));
        
                this.name = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                Validator.CheckIfNumberIsNegative(value, 1, string.Format(GlobalMessages.NumberCannotBeNegative, "Health"));

                this.health = value;
            }
        }

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                Validator.CheckIfNumberIsNegative(value, 1, string.Format(GlobalMessages.NumberCannotBeNegative, "Damage"));

                this.damage = value;
            }
        }

        public WarEffect WarEffect { get; }

        public AttackType AttackType { get; }

        public override string ToString()
        {
            return string.Format(this.Health > 0 ? $"Group {this.Name}: {this.Health} HP, {this.Damage} Damage" : $"Group {this.Name} AMEN");
        }
    }
}
