using System;
using Facade.Devicies;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuner tuner = new Tuner();
            DVDPlayer DVDplayer = new DVDPlayer();
            CDPlayer CDplayer = new CDPlayer();
            Amplifier amplifier = new Amplifier(tuner, CDplayer, DVDplayer);
            Projector projector = new Projector(DVDplayer);
            TheaterLights theaterLights = new TheaterLights();
            Screen screen = new Screen();
            PopcornPopper popcornPopper = new PopcornPopper();
            HomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(amplifier,DVDplayer,popcornPopper,tuner,CDplayer,projector,screen,theaterLights);
            homeTheaterFacade.WatchMovie("1+1");
            Console.WriteLine();
            homeTheaterFacade.EndMovie();
            Console.WriteLine();
            homeTheaterFacade.ListenToCD("Highway to Hell");
            Console.WriteLine();
            homeTheaterFacade.EndCD();
        }
    }
}
