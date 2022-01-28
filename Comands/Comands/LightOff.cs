using Comand.Devices;
namespace Comand.Comands
{
    public class LightOff : ICommand
    {
        private readonly Light light;
        public LightOff(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.LightOff();
        }
        public void Undo()
        {
            light.LightOn();
        }
    }
}