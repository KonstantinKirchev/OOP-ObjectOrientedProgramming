namespace Empires.Contracts
{
    using Models.EventHandlers;

    public interface IResourceProducer
    {
        //bool CanProduceResource { get; }
        //IResource ProduceResource();

        event ResourceProducedEventHandler OnResourceProduced;
    }
}
