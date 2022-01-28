using System.Collections.Generic;
using FactoryBuilder.Ingredients.Cheese;
using FactoryBuilder.Ingredients.Clams;
using FactoryBuilder.Ingredients.Pepperoni;
using FactoryBuilder.Ingredients.Dough;
using FactoryBuilder.Ingredients.Sauce;
using FactoryBuilder.Ingredients.Veggie;

namespace FactoryBuilder.PizzaIngridientFactory
{
    class TiraspolPizzaIngridientFactory: IPizzaIngridientFactory
    {
        public ICheese CreateCheese()
        {
            return new MozarellaCheese();
        }
        public IClams CreateClams()
        {
            return new FreshClams();
        }
        public IPepperoni CreatePepperoni()
        {
            return new WithoutPepperoni();
        }
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }
        public ISauce CreateSause()
        {
            return new MarinaraSauce();
        }
        public List<IVeggie> CreateVeggie()
        {
            return new List<IVeggie>() { new Onion(), new Tomato(), new Pepper() };
        }
    }
}
