using System;

namespace Facade.Devicies
{
    public class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("Lights in theater on");
        }
        public void Off()
        {
            Console.WriteLine("Lights in theater off");
        }
        public void Dim(int dimLevel)
        {
            Console.WriteLine($"Lights power: {dimLevel} ");
        }
    }
}
