using System;

namespace FactoryBuilder.Ingredients.Sauce
{
    public class MarinaraSauce : ISauce
    {
        public void Display()
        {
            Console.WriteLine("Marinara sauce");
        }
    }
}
