using System;
namespace Comand.Devices
{
    public class Stereo
    {
        public void On()
        {
            Console.WriteLine("Stereo on");
        }
        public void Off()
        {
            Console.WriteLine("Stereo off");
        }
        public void SetCD()
        {
            Console.WriteLine("SD on");
        }
        public void SetDVD()
        {
            Console.WriteLine("DVD on");
        }
        public void SetRadio()
        {
            Console.WriteLine("Radio on");
        }
        public void SetVolume(int value)
        {
            Console.WriteLine($"Volume={value}");
        }
    }
}
