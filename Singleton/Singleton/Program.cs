using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ChocolateBoiler chocolateBoiler = ChocolateBoiler.GetInstance();
            chocolateBoiler.Fill();
            chocolateBoiler.Boil();
            chocolateBoiler.Drain();
        }
    }
}