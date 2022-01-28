using System;
using System.Collections.Generic;
using System.Linq;
using Observer.Publisher;
namespace Observer.Subscriber
{
    public class StatisticDisplay: ISubscriber
    {
        public StatisticDisplay (IPublisher publisher)
        {
            publisher.AddSubscriber(this);
        }
        private static List<double> tempList = new List<double>() { 12,15, 32, 29 };
        private static List<double> humidityList = new List<double>() { 38, 46, 45, 25 };
        private static List<double> pressureList = new List<double>() { 652, 771, 713, 881 };
        public void GetNotify(double temp, double pressure, double humidity)
        {
            tempList.Add(temp);
            humidityList.Add(humidity);
            pressureList.Add(pressure);

            Console.WriteLine("Среднее значение за сегодня:");
            Console.WriteLine($"Средняя температура: {FindAverage(tempList)} град. Цельсия");
            Console.WriteLine($"Среднее давление: {FindAverage(pressureList)} мм.рт.ст.");
            Console.WriteLine($"Средняя влажность воздуха: {FindAverage(humidityList)} %");
        }

        private static double FindAverage(List<double> data)
        {
            return data.Average();
        } 
    }
}