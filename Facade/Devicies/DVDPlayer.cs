using System;

namespace Facade.Devicies
{
    public class DVDPlayer
    {
        public void On()
        {
            Console.WriteLine("DVD player on");
        }
        public void Off()
        {
            Console.WriteLine("DVD player off");
        }
        public void Eject()
        {
            Console.WriteLine("DVD disc eject");
        }
        public void Pause()
        {
            Console.WriteLine("DVD pause");
        }
        public void Play(string video)
        {
            Console.WriteLine($"Now playing: {video}");
        }
        public void Stop()
        {
            Console.WriteLine("DVD is stopped");
        }
    }
}
