using System;

namespace FactoryBuilder.Ingredients.Pepperoni
{
    public class WithPepperoni:IPepperoni
    {
        public void Display()
        {
            Console.WriteLine("With pepperoni");
        }
    }
}
