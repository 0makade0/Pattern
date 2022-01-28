using System;

namespace FactoryBuilder.Ingredients.Clams
{
    public class FreshClams:IClams
    {
        public void Display()
        {
            Console.WriteLine("Fresh Clams");
        }
    }
}
