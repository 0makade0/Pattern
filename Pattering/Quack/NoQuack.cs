using System;
namespace Pattering.Quack
{
    public class NoQuack: IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Эта уточка не крякает!");
        }
    }
}