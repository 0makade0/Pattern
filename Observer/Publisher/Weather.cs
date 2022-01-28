using System;
using System.Collections.Generic;
using Observer.Publisher;
using Observer.Subscriber;
namespace Observer
{
    public class Weather: IPublisher
    {
        private static List<ISubscriber> subscribers = new List<ISubscriber>();
        Random rand = new Random();

        public void AddSubscriber(ISubscriber sub)
        {
            subscribers.Add(sub);
        }

        public void DeleteSubscriber(ISubscriber sub)
        {
            if (subscribers.Exists(s => s.Equals(sub)))
            {
                subscribers.Remove(sub);
            }
            else
            {
                Console.WriteLine("Такого подписчика не существует");
            }
        }

        public double GetTemperature()
        {
            double t = rand.Next(0, 40);
            return t;
        }

        public double GetPressure()
        {
            double p = rand.Next(600, 800);
            return p;
        }

        public double GetHumidity()
        {
            double h = rand.Next(30, 60); 
            return h;
        }

        public void Notify()
        {
            foreach (var item in subscribers)
            {
                item.GetNotify(GetTemperature(), GetPressure(), GetHumidity());
            }
        }
    }
}