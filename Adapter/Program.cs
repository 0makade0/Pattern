using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Turkey turkey = new Turkey();
            BirdAdapter adaptedTurkey = new BirdAdapter(turkey);

            adaptedTurkey.Fly();
            adaptedTurkey.MakeSound();
        }
    }
}
