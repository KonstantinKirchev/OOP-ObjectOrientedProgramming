using Battleships.Interfaces;

namespace Battleships.Ships
{
    public abstract class Battleship : Ship, IAttack
    {
        protected Battleship(string name, double lengthInMeters, double volume) 
            : base(name, lengthInMeters, volume)
        {
        }

        public abstract string Attack(Ship targetShip);

        protected void DestroyTarget(Ship targetShip)
        {
            targetShip.IsDestroyed = true;
        }
    }
}
