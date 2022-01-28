using System;

namespace FactoryBuilder.Ingredients.Veggie
{
    public class Onion: IVeggie
    {
        public void Display()
        {
            Console.WriteLine("Onion");
        }
    }
}
