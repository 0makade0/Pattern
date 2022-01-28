using System;

namespace Singleton
{
    public class ChocolateBoiler
    {
        public bool Empty { get; private set; }
        public bool Boiled { get; private set; }
        private static ChocolateBoiler uniqueInstance;
        private static object Lock = new object();
        private ChocolateBoiler()
        {
            Empty = true;
            Boiled = false;
        }
        public static ChocolateBoiler GetInstance()
        {
            if (uniqueInstance == null)
            {
                lock (Lock)
                {
                    if (uniqueInstance == null)
                    {
                        uniqueInstance = new ChocolateBoiler();
                    }
                }
            }
            return uniqueInstance;
        }
        public void Fill()
        {
            if (Empty)
            {
                Empty = false;
                Boiled = false;
                Console.WriteLine("Boiler filling");
            }
        }
        public void Drain()
        {
            if (!Empty && Boiled)
            {
                Empty = true;
                Console.WriteLine("Draining");
            }
        }
        public void Boil()
        {
            if (!Empty && !Boiled)
            {
                Boiled = true;
                Console.WriteLine("Boiling");
            }
        }
    }
}
