using System;
using Pattering.Swim;
using Pattering.Fly;
using Pattering.Quack;
namespace Pattering
{
    class RubberDuck: Duck
    {
        public override void Display()
        {
            Console.WriteLine("Это резиновая уточка");
            base.Display();
        }
        public RubberDuck()
            :base(new NoFly(), new RubberDuckQuack(), new Swimable())
        { }
    }
}