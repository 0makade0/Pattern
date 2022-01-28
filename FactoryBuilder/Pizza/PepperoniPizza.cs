using FactoryBuilder.PizzaIngridientFactory;

namespace FactoryBuilder.Pizza
{
    class PepperoniPizza: Pizzas
    {
        public IPizzaIngridientFactory Factory { get; set; }

        public PepperoniPizza(IPizzaIngridientFactory ingridientFactory)
        {
            this.Factory = ingridientFactory;
        }
        public override void Prepare()
        {
            Name = "Pepperoni pizza";
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSause();
            Cheese = Factory.CreateCheese();
            Pepperoni = Factory.CreatePepperoni();
        }
    }
}
