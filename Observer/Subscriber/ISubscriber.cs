namespace Observer.Subscriber
{
    public interface ISubscriber
    {
        void GetNotify(double t, double p, double h);
    }
}