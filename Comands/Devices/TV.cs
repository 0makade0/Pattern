using System;

namespace Comand.Devices
{
    public class TV
    {
        public void On()
        {
            Console.WriteLine("TV on");
        }
        public void Off()
        {
            Console.WriteLine("TV off");
        }
        public void SetInputChannel(int valueChannel)
        {
            Console.WriteLine($"Channel on TV № {valueChannel}");
        }
        public void SetVolume(int valueVolume)
        {
            Console.WriteLine($"Volume={valueVolume}");
        }
    }
}
