using System;

namespace Template_method
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Do you want add addition on your Beverage?");
            string answer = Console.ReadLine();
            bool userChoice;
            if (answer=="Yes")
            {
                userChoice = true;
            }
            else
            {
                userChoice = false;
            }
            Tea tea = new Tea(userChoice);
            Coffee coffee = new Coffee(userChoice);
            
            tea.prepareRecipe();
            Console.WriteLine();
            coffee.prepareRecipe();
        }
    }
}