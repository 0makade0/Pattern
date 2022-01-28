using System;
namespace Pattering.Fly
{
    public class FlyWithWings:IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Эта уточка can fly");
        }
    }
}