using System;

namespace FactoryBuilder.Ingredients.Cheese
{
    public class ReggianoCheese: ICheese
    {
        public void Display()
        {
            Console.WriteLine("Reggiano Cheese");
        }
    }
}
