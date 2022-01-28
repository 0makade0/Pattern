using System;
namespace Comand.Devices
{
    public class GardenLight
    {
        public void SetDuskTime(int hour)
        {
            Console.WriteLine($"Garden lighting is included in {hour} h.");
        }
        public void SetDawnTime(int hour)
        {
            Console.WriteLine($"The garden lights turn off in {hour} h.");
        }
        public void ManualOn()
        {
            Console.WriteLine("Manual light on");
        }
        public void ManualOff()
        {
            Console.WriteLine("Manual light off");
        }
    }
}
