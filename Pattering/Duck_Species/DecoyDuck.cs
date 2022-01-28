using System;
using Pattering.Swim;
using Pattering.Fly;
using Pattering.Quack;
namespace Pattering
{
    class DecoyDuck:Duck
    {
        public override void Display()
        {
            Console.WriteLine("Это ложная уточка"); 
            base.Display();
        }
        public DecoyDuck()
            : base(new NoFly(),new NoQuack(), new Swimable())
        { }
    }
}