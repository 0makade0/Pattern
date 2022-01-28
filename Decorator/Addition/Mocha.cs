namespace Decorator.Addition
{
    public class Mocha:CondimentDecorator
    {
        Beverage beverageDecorator;
        public Mocha(Beverage beverage)
        {
            this.beverageDecorator = beverage;
        }

        public override int Cost()
        {
            return beverageDecorator.Cost() + 2;
        }
        public override string GetDescription()
        {
            return beverageDecorator.GetDescription() + " + Mocha";
        }
    }
}