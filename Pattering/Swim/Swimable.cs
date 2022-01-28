using System;
namespace Pattering.Swim
{
    public class Swimable: ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Эта уточка умеет плавать");
        }
    }
}