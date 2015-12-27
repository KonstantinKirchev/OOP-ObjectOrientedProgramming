﻿namespace Battleships.Ships
{
    using System;

    public class Destroyer : BattleShip
    {
        private int numberOfAmmunition;

        public Destroyer(string name, double lengthInMeters, double volume, int numberOfAmmunition)
            : base(name,lengthInMeters,volume)
        {
            this.NumberOfAmmunition = numberOfAmmunition;
            this.IsBattleship = true;
        }

        public int NumberOfAmmunition
        {
            get
            {
                return this.numberOfAmmunition;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("value", "The number of ammunition in a destroyer cannot be negative.");
                }

                this.numberOfAmmunition = value;
            }
        }

        public override string Attack(Ship targetShip)
        {
            targetShip.IsDestroyed = true;
            return "They didn't see us coming!";
        }
    }
}
