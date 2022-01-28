using System;
namespace Comand.Devices
{
    public class CeilingFan
    {
        public readonly int HIGH = 3;
        public readonly int MEDIUM = 2;
        public readonly int LOW = 1;
        public readonly int OFF = 0;
        public int speed { get; set; }

        public void High()
        {
            Console.WriteLine("High ceiling fan speed on");
            speed = HIGH;
        }
        public void Medium()
        {
            Console.WriteLine("Medium ceiling fan speed on");
            speed = MEDIUM;
        }
        public void Low()
        {
            Console.WriteLine("Low ceiling fan speed on");
            speed = LOW;
        }
        public void Off()
        {
            Console.WriteLine("Ceiling fan off");
            speed = OFF;
        }
        public int getSpeed()
        {
            return speed;
        }
    }
}
