using System;
namespace Pattering.Quack
{
    public class RubberDuckQuack: IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Эта резиновая уточка крякает по-своему");
        }
    }
}