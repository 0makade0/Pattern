using System;
namespace Pattering.Quack
{
    public class DuckQuack: IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Эта уточка крякает");
        }
    }
}