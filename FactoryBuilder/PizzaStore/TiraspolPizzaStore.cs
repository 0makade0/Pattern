using System;
using FactoryBuilder.Pizza;
using FactoryBuilder.PizzaIngridientFactory;

namespace FactoryBuilder.PizzaStore
{
    public class TiraspolPizzaStore: PizzaStore
    {
        public IPizzaIngridientFactory IngredientFactory { get; set; } = new TiraspolPizzaIngridientFactory();
        public override Pizzas CreatePizza(string type)
        {
            if (type == "cheese" || type == "Cheese")
            {
                return new CheesePizza(IngredientFactory);
            }
            else if (type == "clam" || type == "Clam")
            {
                return new ClamPizza(IngredientFactory);
            }
            else if (type == "pepperoni" || type == "Pepperoni")
            {
                return new PepperoniPizza(IngredientFactory);
            }
            else if (type == "veggie" || type == "Veggie")
            {
                return new VeggiePizza(IngredientFactory);
            }
            else return null;
        }
    }
}
