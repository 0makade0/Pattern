using FactoryBuilder.PizzaIngridientFactory;

namespace FactoryBuilder.Pizza
{
    class VeggiePizza:Pizzas
    {
        public IPizzaIngridientFactory Factory { get; set; }
        public VeggiePizza(IPizzaIngridientFactory ingridientFactory)
        {
            this.Factory = ingridientFactory;
        }
        public override void Prepare()
        {
            Name = "Veggie pizza";
            Dough = Factory.CreateDough();
            Sauce = Factory.CreateSause();
            Cheese = Factory.CreateCheese();
            Veggies = Factory.CreateVeggie();
        }
    }
}
