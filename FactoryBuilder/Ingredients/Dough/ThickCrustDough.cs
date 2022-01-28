using System;

namespace FactoryBuilder.Ingredients.Dough
{
    public class ThickCrustDough:IDough
    {
        public void Display()
        {
            Console.WriteLine("Thick crust dough");
        }
    }
}
