using Comand.Devices;
namespace Comand.Comands
{
    public class GarageDoorOpen : ICommand
    {
        private readonly GarageDoor garageDoor;
        public GarageDoorOpen(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.GarageLightOn();
            garageDoor.GarageDoorUp();
        }

        public void Undo()
        {
            garageDoor.GarageLightOff();
            garageDoor.GarageDoorDown();
        }
    }
}
