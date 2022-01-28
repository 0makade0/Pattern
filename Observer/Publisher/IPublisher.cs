using Observer.Subscriber;
namespace Observer.Publisher
{
    public interface IPublisher
    {
        void AddSubscriber(ISubscriber sub);
        void DeleteSubscriber(ISubscriber sub);
    }
}