using System;
using System.Collections.Generic;
using FactoryBuilder.Ingredients.Cheese;
using FactoryBuilder.Ingredients.Clams;
using FactoryBuilder.Ingredients.Pepperoni;
using FactoryBuilder.Ingredients.Dough;
using FactoryBuilder.Ingredients.Sauce;
using FactoryBuilder.Ingredients.Veggie;

namespace FactoryBuilder.Pizza
{
    public abstract class Pizzas
    {
        public string Name { get; set; }
        public ICheese Cheese { get; set; }
        public IClams Clams { get; set; }
        public IPepperoni Pepperoni { get; set; }
        public IDough Dough { get; set; }
        public ISauce Sauce { get; set; }
        public List<IVeggie> Veggies = new List<IVeggie>();
        public abstract void Prepare();
        public void Bake()
        {
            Console.WriteLine("Baking for 20 minutes at 180");
        }
        public void Cut()
        {
            Console.WriteLine("Cutting pizza");
        }
        public void Box()
        {
            Console.WriteLine("Boxing pizza");
        }
    }
}