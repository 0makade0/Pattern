using System;
namespace Pattering
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var mallardduck = new MallardDuck();
            var redheadduck = new RedheadDuck();
            var decoyduck = new DecoyDuck();
            var rubberduck = new RubberDuck();

            mallardduck.Display();
            Console.WriteLine();

            redheadduck.Display();
            Console.WriteLine();

            rubberduck.Display();
            Console.WriteLine();

            decoyduck.Display();

            Console.WriteLine("Убийство рыжей уточки");
            redheadduck.Dead();
            redheadduck.Fly();
            redheadduck.Quack();
            redheadduck.Swim();
        }
    }
}