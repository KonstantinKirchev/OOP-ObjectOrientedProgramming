﻿namespace Battleships.Ships
{
    using System;

    public class Warship : BattleShip
    {

        public Warship(string name, double lengthInMeters, double volume)
            :base(name,lengthInMeters,volume)
        {
            this.IsBattleship = true;
        }

       
        public override string Attack(Ship targetShip)
        {
            targetShip.IsDestroyed = true;
            return "Victory is ours!";
        }
    }
}
