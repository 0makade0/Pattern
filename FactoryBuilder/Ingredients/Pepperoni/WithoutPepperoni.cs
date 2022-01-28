using System;

namespace FactoryBuilder.Ingredients.Pepperoni
{
    public class WithoutPepperoni:IPepperoni
    {
        public void Display()
        {
            Console.WriteLine("Without pepperoni");
        }
    }
}
