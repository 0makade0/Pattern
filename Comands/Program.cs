using Comand.Comands;
using Comand.Devices;
using Command;

namespace Comand
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            CeilingFan ceilingFan = new CeilingFan();
            GarageDoor garageDoor = new GarageDoor();
            Light light = new Light();
            Stereo stereo = new Stereo();
            LightOn onLight = new LightOn(light);
            LightOff offLight = new LightOff(light);
            GarageDoorOpen openGarageDoor = new GarageDoorOpen(garageDoor);
            GarageDoorClose closeGarageDoor = new GarageDoorClose(garageDoor);
            CeilingFanSpeed ceilingFanSpeed = new CeilingFanSpeed(ceilingFan);
            CeilingFanOff ceilingFanOff = new CeilingFanOff(ceilingFan);
            StereoOn stereoOn = new StereoOn(stereo);
            StereoOff stereoOff = new StereoOff(stereo);
            remoteControl.SetCommand(0, onLight, offLight);
            remoteControl.SetCommand(1, openGarageDoor, closeGarageDoor);
            remoteControl.SetCommand(2, ceilingFanSpeed, ceilingFanOff);
            remoteControl.SetCommand(3, stereoOn, stereoOff);
        }
    }
}
