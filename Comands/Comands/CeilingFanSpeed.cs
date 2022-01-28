using Comand.Devices;

namespace Comand.Comands
{
    public class CeilingFanSpeed: ICommand
    {
        private readonly CeilingFan ceilingFan;
        private int prevSpeed;
        public CeilingFanSpeed(CeilingFan ceilingFan)
        {
            this.ceilingFan = ceilingFan;
        }
        public void Execute()
        {
            prevSpeed = ceilingFan.getSpeed();
        }
        public void Undo()
        {
            if (prevSpeed == ceilingFan.HIGH)
            {
                ceilingFan.High();
            }
            else if (prevSpeed == ceilingFan.MEDIUM)
            {
                ceilingFan.Medium();
            }
            else if (prevSpeed == ceilingFan.LOW)
            {
                ceilingFan.Low();
            }
            else if (prevSpeed == ceilingFan.OFF)
            {
                ceilingFan.Low();
            }
        }
    }
}
