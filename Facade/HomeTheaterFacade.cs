using Facade.Devicies;

namespace Facade
{
    public class HomeTheaterFacade
    {
        public Amplifier amplifier { get; set; }
        public CDPlayer CDplayer { get; set; }
        public DVDPlayer DVDplayer { get; set; }
        public PopcornPopper popcornPopper { get; set; }
        public Projector projector { get; set; }
        public Screen screen { get; set; }
        public TheaterLights theaterLights { get; set; }
        public Tuner tuner { get; set; }
        public HomeTheaterFacade(
            Amplifier amplifier, DVDPlayer DVDplayer, PopcornPopper popcornPopper, Tuner tuner,
            CDPlayer CDplayer, Projector projector, Screen screen, TheaterLights theaterLights
            )
        {
            this.amplifier = amplifier;
            this.tuner = tuner;
            this.DVDplayer = DVDplayer;
            this.CDplayer = CDplayer;
            this.projector = projector;
            this.theaterLights = theaterLights;
            this.screen = screen;
            this.popcornPopper = popcornPopper;
        }
        public void WatchMovie(string video)
        {
            popcornPopper.On();
            popcornPopper.Pop();
            theaterLights.Dim(10);
            screen.Down();
            projector.On();
            projector.WideScreenMovie();
            amplifier.On();
            amplifier.SetDVD();
            amplifier.SetSurroundSound();
            amplifier.SetVolume(40);
            DVDplayer.On();
            DVDplayer.Play(video);
        }
        public void EndMovie()
        {
            DVDplayer.Stop();
            DVDplayer.Eject();
            DVDplayer.Off();
            amplifier.Off();
            projector.Off();
            screen.Up();
            theaterLights.On();
            popcornPopper.Off(); 
        }
        public void ListenToCD(string song)
        {
            theaterLights.Dim(20);
            amplifier.On();
            amplifier.SetCD();
            amplifier.SetSurroundSound();
            amplifier.SetVolume(50);
            CDplayer.On();
            CDplayer.Play(song);
        }

        public void EndCD()
        {
            CDplayer.Stop();
            CDplayer.Eject();
            CDplayer.Off();
            amplifier.Off();
            theaterLights.On();
        }

        public void ListenRadio(int frequency)
        {
            theaterLights.Dim(10);
            amplifier.On();
            amplifier.SetTuner();
            amplifier.SetSurroundSound();
            amplifier.SetVolume(50);
            tuner.On();
            tuner.SetFm(frequency);
        }

        public void EndRadio()
        {
            tuner.Off();
            amplifier.Off();
            theaterLights.On();
        }
    }
}
