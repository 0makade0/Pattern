using System.Collections.Generic;
using FactoryBuilder.Ingredients.Cheese;
using FactoryBuilder.Ingredients.Clams;
using FactoryBuilder.Ingredients.Pepperoni;
using FactoryBuilder.Ingredients.Dough;
using FactoryBuilder.Ingredients.Sauce;
using FactoryBuilder.Ingredients.Veggie;


namespace FactoryBuilder.PizzaIngridientFactory
{
    class BenderyPizzaIngridientFactory: IPizzaIngridientFactory
    {
        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }
        public IClams CreateClams()
        {
            return new FrozenClams();
        }
        public IPepperoni CreatePepperoni()
        {
            return new WithPepperoni();
        }
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }
        public ISauce CreateSause()
        {
            return new PlumtomatoSauce();
        }
        public List<IVeggie> CreateVeggie()
        {
            return new List<IVeggie>() { new Onion(), new Tomato() };
        }
    }
}
