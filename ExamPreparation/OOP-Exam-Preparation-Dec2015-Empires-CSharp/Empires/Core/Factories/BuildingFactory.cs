namespace Empires.Core.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;

    using Empires.Models.Buildings;

    public class BuildingFactory : IBuildingFactory
    {
        public IBuilding CreateBuilding(string buildingType, IUnitFactory unitFactory, IResourceFactory resourceFactory)
        {
            //switch (buildingType)
            //{
            //    case "archery":
            //        return new Archery(unitFactory, resourceFactory);
            //    case "barracks":
            //        return new Barracks(unitFactory, resourceFactory);
            //    default:
            //        throw new ArgumentException("Unknown building type.");
            //}

            var type = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(t => t.Name.ToLowerInvariant() == buildingType);

            if (type == null)
            {
                throw new ArgumentException("Unknown building type.");
            }

            var building = (IBuilding)Activator.CreateInstance(type, unitFactory, resourceFactory);

            return building;
        }
    }
}
