using Comand.Devices;

namespace Comand.Comands
{
    public class StereoOn : ICommand
    {
        private readonly Stereo stereo;
        public StereoOn(Stereo stereo)
        {
            this.stereo = stereo;
        }

        public void Execute()
        {
            stereo.On();
            stereo.SetCD();
            stereo.SetVolume(4);
        }
        public void Undo()
        {
            stereo.Off();
        }
    }
}