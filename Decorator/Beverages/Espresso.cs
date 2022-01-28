namespace Decorator.Beverages
{
    public class Espresso: Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }
        public override int Cost()
        {
            return 13;
        }
    }
}