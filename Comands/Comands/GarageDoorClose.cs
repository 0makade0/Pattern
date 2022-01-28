using Comand.Devices;
namespace Comand.Comands
{
    public class GarageDoorClose: ICommand
    {
        private readonly GarageDoor garageDoor;
        public GarageDoorClose(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.GarageLightOff();
            garageDoor.GarageDoorDown();
        }

        public void Undo()
        {
            garageDoor.GarageLightOn();
            garageDoor.GarageDoorUp();
        }
    }
}
