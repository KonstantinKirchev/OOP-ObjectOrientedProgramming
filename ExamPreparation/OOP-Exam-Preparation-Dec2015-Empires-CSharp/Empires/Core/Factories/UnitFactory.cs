namespace Empires.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;

    using Empires.Models.Units;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            //switch (unitType)
            //{
            //    case "Archer":
            //        return new Archer();
            //    case "Swordsman":
            //        return new Swordsman();
            //    default:
            //        throw new ArgumentException("Unknown unit type.");
            //}

            var type = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(t => t.Name == unitType);

            if (type == null)
            {
                throw new ArgumentException("Unknown unit type.");
            }

            var unit = (IUnit)Activator.CreateInstance(type);

            return unit;
        }
    }
}
