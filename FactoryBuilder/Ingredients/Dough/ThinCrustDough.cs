using System;

namespace FactoryBuilder.Ingredients.Dough
{
    public class ThinCrustDough: IDough
    {
        public void Display()
        {
            Console.WriteLine("Thin crust dough");
        }
    }
}
