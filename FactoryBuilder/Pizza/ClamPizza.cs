using FactoryBuilder.PizzaIngridientFactory;

namespace FactoryBuilder.Pizza
{
    class ClamPizza: Pizzas
    {
        public IPizzaIngridientFactory Factory { get; set; }
        public ClamPizza(IPizzaIngridientFactory ingridientFactory)
        {
            this.Factory = ingridientFactory;
        }
        public override void Prepare()
        {
            Name = "Clam pizza";
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSause();
            Cheese = Factory.CreateCheese();
            Clams = Factory.CreateClams();
        }
    }
}
