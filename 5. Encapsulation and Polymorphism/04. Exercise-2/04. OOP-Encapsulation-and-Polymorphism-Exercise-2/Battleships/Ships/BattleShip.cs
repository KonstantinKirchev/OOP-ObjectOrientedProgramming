﻿namespace Battleships.Ships
{
    public abstract class BattleShip : Ship, IAttack
    {
        

        protected BattleShip(string name, double lengthInMeters, double volume) 
            : base(name, lengthInMeters, volume)
        {
        }

        public abstract string Attack(Ship targetShip);

        protected void DestroyShip(Ship target)
        {
            
        }
    }
}
