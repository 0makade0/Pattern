using System;

namespace Facade.Devicies
{
    public class Tuner
    {
        public void On()
        {
            Console.WriteLine("Tuner on");
        }
        public void Off()
        {
            Console.WriteLine("Tuner off");
        }
        public void SetAm()
        {
            Console.WriteLine("Set Am mode in tuner");
        }
        public void SetFm()
        {
            Console.WriteLine("Set Fm mode in tuner");
        }
        public void SetFm(double frequency)
        {
            Console.WriteLine($"Set frequency on tuner: {frequency}");
        }
    }
}
