namespace Empires.Contracts
{
    using Models.EventHandlers;

    public interface IUnitProducer
    {
        //bool CanProduceUnit { get; }
        //IUnit ProduceUnit();

        event UnitProducedEventHandler OnUnitProduced;
    }
}
