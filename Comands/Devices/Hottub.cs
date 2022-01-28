using System;
namespace Comand.Devices
{
    public class Hottub
    {
        public void Circulate()
        {
            Console.WriteLine("Hottub:circulating");
        }
        public void JetsOn()
        {
            Console.WriteLine("Jets on");
        }
        public void JetsOff()
        {
            Console.WriteLine("Jets off");
        }
        public void SetTemperature(int value)
        {
            Console.WriteLine($"Hottub temperature={value}");
        }
    }
}
