using Comand.Devices;
namespace Comand.Comands
{
    public class LightOn: ICommand
    {
        private readonly Light light;
        public LightOn(Light light)
        {
            this.light = light;
        }
        public void Execute()
        {
            light.LightOn();
        }
        public void Undo()
        {
            light.LightOff();
        }
    }
}