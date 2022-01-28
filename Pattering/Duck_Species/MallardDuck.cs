using System;
using Pattering.Swim;
using Pattering.Fly;
using Pattering.Quack;
namespace Pattering
{
    class MallardDuck: Duck
    {
        public override void Display()
        {
            Console.WriteLine("Это Селезень");
            base.Display();
        }
        public MallardDuck()
            : base(new FlyWithWings(), new DuckQuack(), new Swimable())
        { }
    }
}