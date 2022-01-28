using System;

namespace Facade.Devicies
{
    public class Projector
    {
        public DVDPlayer DVDplayer{get;set;}
        public Projector(DVDPlayer dvd)
        {
            this.DVDplayer = dvd;
        }
        public void On()
        {
            Console.WriteLine("Projector on");
        }
        public void Off()
        {
            Console.WriteLine("Projector off");
        }
        public void tvMode()
        {
            Console.WriteLine("TV mode on projector");
        }
        public void WideScreenMovie()
        {
            Console.WriteLine("Widescreen mode enabled");
        }
    }
}
