using FactoryBuilder.PizzaIngridientFactory;

namespace FactoryBuilder.Pizza
{
    class CheesePizza: Pizzas
    {
        public IPizzaIngridientFactory Factory { get; set; }
        public CheesePizza(IPizzaIngridientFactory ingridientFactory)
        {
            this.Factory = ingridientFactory;
        }
        public override void Prepare()
        {
            Name = "Cheese pizza";
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSause();
            Cheese = Factory.CreateCheese();
        }
    }
}
