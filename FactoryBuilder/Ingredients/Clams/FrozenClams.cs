using System;

namespace FactoryBuilder.Ingredients.Clams
{
    public class FrozenClams: IClams
    {
        public void Display()
        {
            Console.WriteLine("Frozen Clams");
        }
    }
}
