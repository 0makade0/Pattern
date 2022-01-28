namespace Decorator.Addition
{
    public class Soy : CondimentDecorator
    {
        Beverage beverageDecorator;
        public Soy(Beverage beverage)
        {
            this.beverageDecorator=beverage;
        }
        public override int Cost()
        {
            return beverageDecorator.Cost() + 2;
        }
        public override string GetDescription()
        {
            return beverageDecorator.GetDescription() + " + Soy";
        }
    }
}