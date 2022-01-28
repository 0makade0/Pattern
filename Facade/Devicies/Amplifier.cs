using System;

namespace Facade.Devicies
{
    public class Amplifier
    {
        public Tuner tuner { get; set; }
        public CDPlayer CDplayer{ get; set; }
        public DVDPlayer DVDplayer{ get; set; }
        public Amplifier(Tuner tuner, CDPlayer CDplayer, DVDPlayer DVDplayer)
        {
            this.tuner = tuner;
            this.CDplayer = CDplayer;
            this.DVDplayer = DVDplayer;
        }
        public void On()
        {
            Console.WriteLine("Amplifier on");
        }
        public void Off()
        {
            Console.WriteLine("Amplifier off");
        }
        public void SetCD()
        {
            Console.WriteLine("Amplifier set CD");
        }
        public void SetDVD()
        {
            Console.WriteLine("Amplifier set DVD");
        }
        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier set stereo sound");
        }
        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier set surround sound.");
        }
        public void SetTuner()
        {
            Console.WriteLine("Amplifier set tuner");
        }
        public void SetVolume(int value)
        {
            Console.WriteLine($"Amplifier volume: {value}");
        }
    }
}
