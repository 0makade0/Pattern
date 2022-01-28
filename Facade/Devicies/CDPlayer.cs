using System;

namespace Facade.Devicies
{
    public class CDPlayer
    {
        public void On()
        {
            Console.WriteLine("CD player on");
        }
        public void Off()
        {
            Console.WriteLine("CD player off");
        }
        public void Eject()
        {
            Console.WriteLine("Disk on CD player eject");
        }
        public void Pause()
        {
            Console.WriteLine("CD player pause");
        }
        public void Play(string song)
        {
            Console.WriteLine($"CD player play: {song}");
        }
        public void Stop()
        {
            Console.WriteLine("CD player stopped");
        }
    }
}
