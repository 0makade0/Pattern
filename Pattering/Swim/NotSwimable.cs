using System;
namespace Pattering.Swim
{
    public class NotSwimable: ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Эта уточка не умеет плавать");
        }
    }
}