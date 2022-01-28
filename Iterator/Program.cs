namespace Iterator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Waitress waitress = new Waitress(new PancakeMenu(), new DinerMenu());

            waitress.PrintMenu();
        }
    }
}