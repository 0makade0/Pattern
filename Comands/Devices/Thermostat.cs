using System;
namespace Comand.Devices
{
    public class Thermostat
    {
        public void SetTemperature(int value)
        {
            Console.WriteLine($"Temperature={value}");
        }
    }
}
