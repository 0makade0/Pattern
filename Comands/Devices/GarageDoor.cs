using System;
namespace Comand.Devices
{
    public class GarageDoor
    {
        public void GarageDoorUp()
        {
            Console.WriteLine("Garage door is up");
        }
        public void GarageDoorDown()
        {
            Console.WriteLine("Garage door is down");
        }
        public void GarageDoorStop()
        {
            Console.WriteLine("Garage doors stopped");
        }
        public void GarageLightOn()
        {
            Console.WriteLine("Garage light on");
        }
        public void GarageLightOff()
        {
            Console.WriteLine("Garage light off");
        }
    }
}
