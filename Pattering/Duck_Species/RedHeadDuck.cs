using System;
using Pattering.Swim;
using Pattering.Fly;
using Pattering.Quack;
namespace Pattering
{
    class RedheadDuck:Duck
    {
        public override void Display()
        {
            Console.WriteLine("Это рыжая уточка");
            base.Display();
        }
        public RedheadDuck()
            :base(new FlyWithWings(),new DuckQuack(),new Swimable())
        { }
    }
}