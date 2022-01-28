namespace Decorator.Beverages
{
    public class Decaf: Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }
        public override int Cost()
        {
            return 14;
        }
    }
}