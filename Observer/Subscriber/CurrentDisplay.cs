using System;
using Observer.Publisher;
namespace Observer.Subscriber
{
    public class CurrentDisplay: ISubscriber
    {
        public CurrentDisplay (IPublisher publisher)
        {
            publisher.AddSubscriber(this);
        }
        public void GetNotify(double t, double p, double h)
        {
            Console.WriteLine("Информация на данный момент времени:");
            Console.WriteLine($"Температура: {t} град. Цельсия");
            Console.WriteLine($"Давление: {p} мм.рт.ст");
            Console.WriteLine($"Влажность воздуха: {h} %");
        }
    }
}