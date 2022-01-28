using System;
namespace Pattering.Fly
{
    public class NoFly: IFlyBehavior
    {
        public void Fly() 
        {
            Console.WriteLine("Эта уточка can't fly");
        }
    }
}