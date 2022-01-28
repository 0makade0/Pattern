using System;
using FactoryBuilder.PizzaStore;

namespace FactoryBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            BenderyPizzaStore benderyPizzaStore = new BenderyPizzaStore();
            var one = benderyPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"{one.Name} is ready");

            Console.WriteLine();

            TiraspolPizzaStore tiraspolPizzaStore = new TiraspolPizzaStore();
            var two = tiraspolPizzaStore.OrderPizza("veggie");
            Console.WriteLine($"{two.Name} is ready");

            Console.WriteLine();

            var three = tiraspolPizzaStore.OrderPizza("clam");
            Console.WriteLine($"{three.Name} is ready");
        }
    }
}
