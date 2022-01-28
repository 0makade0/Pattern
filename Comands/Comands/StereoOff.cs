using Comand.Devices;

namespace Comand.Comands
{
    public class StereoOff : ICommand
    {
        private readonly Stereo stereo;
        public StereoOff(Stereo stereo)
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