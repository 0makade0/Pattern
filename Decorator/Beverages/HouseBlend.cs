namespace Decorator.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend";
        }
        public override int Cost()
        {
            return 15;
        }
    }
}