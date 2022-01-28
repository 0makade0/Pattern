namespace Decorator.Addition
{ 
    public class Milk : CondimentDecorator
    {
        Beverage beverageDecorator;
        public Milk(Beverage beverage)
        {
            this.beverageDecorator = beverage;
        }
        public override int Cost()
        {
            return beverageDecorator.Cost() + 1;
        }
        public override string GetDescription()
        {
            return beverageDecorator.GetDescription() + " + Milk";
        } 
    }
}