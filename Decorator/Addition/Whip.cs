namespace Decorator.Addition
{
    public class Whip : CondimentDecorator
    {
        Beverage beverageDecorator;
        public Whip(Beverage beverage)
        {
            this.beverageDecorator = beverage;
        }
        public override int Cost()
        {
            return beverageDecorator.Cost() + 3;
        }
        public override string GetDescription()
        {
            return beverageDecorator.GetDescription() + " + Whip";
        }
    }
}