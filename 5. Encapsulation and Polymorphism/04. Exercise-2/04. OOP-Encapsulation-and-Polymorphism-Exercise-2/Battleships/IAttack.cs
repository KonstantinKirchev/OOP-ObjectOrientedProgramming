﻿using Battleships.Ships;

namespace Battleships
{
    public interface IAttack
    {
        string Attack(Ship targetShip);
    }
}
