namespace Decorator.Beverages
{
    public class DarkRoast:Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }
        public override int Cost()
        {
            return 16;
        }
    }
}