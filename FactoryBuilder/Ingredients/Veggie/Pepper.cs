using System;

namespace FactoryBuilder.Ingredients.Veggie
{
    public class Pepper : IVeggie
    {
        public void Display()
        {
            Console.WriteLine("Pepper");
        }
    }
}
