using System;
namespace Comand.Devices
{
    public class SecurityControl
    {
        public void Arm()
        {
            Console.WriteLine("SC:armed");
        }
        public void Disarm()
        {
            Console.WriteLine("SC:disarmed");
        }
    }
}
