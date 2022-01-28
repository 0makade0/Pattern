using System;
namespace Comand.Devices
{
    public class CeilingLight
    {
        public void On()
        {
            Console.WriteLine("Ceiling light on");
        }
        public void Off()
        {
            Console.WriteLine("Ceiling light off");
        }
        public void Dim()
        {
            Console.WriteLine("Ceiling light on dim");
        }
    }
}
