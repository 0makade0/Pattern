using Observer.Publisher;
using Observer.Subscriber;
namespace Observer
{
    internal class Program
    {
        public static void Main(string[] args)
        { 
            Weather weatherData = new Weather();
            CurrentDisplay display1 = new CurrentDisplay(weatherData);
            StatisticDisplay display2 = new StatisticDisplay(weatherData);
            weatherData.Notify();
        }
    }
}