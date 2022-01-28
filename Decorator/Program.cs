using System;
using Decorator.Addition;
using Decorator.Beverages;
namespace Decorator
{
    internal class Program
    {
        public static void Main()
        { 
            //DarkRoast+Milk+Whip
            Beverage darkRoast = new DarkRoast();
            darkRoast = new Milk(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine($"{darkRoast.GetDescription()}:{darkRoast.Cost()}");
            //HouseBlend+Soy+whip
            Beverage houseBlend = new HouseBlend();
            houseBlend = new Soy(houseBlend);
            houseBlend = new Whip(houseBlend);
            Console.WriteLine($"{houseBlend.GetDescription()}:{houseBlend.Cost()}");
            //Espresso+all addishion
            Beverage espresso = new Espresso();
            espresso = new Soy(espresso);
            espresso = new Whip(espresso);
            espresso = new Milk(espresso);
            espresso = new Mocha(espresso);
            Console.WriteLine($"{espresso.GetDescription()}:{espresso.Cost()}");
            Console.ReadLine();
        }
    }
}