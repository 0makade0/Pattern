using System.Collections.Generic;
using FactoryBuilder.Ingredients.Cheese;
using FactoryBuilder.Ingredients.Clams;
using FactoryBuilder.Ingredients.Dough;
using FactoryBuilder.Ingredients.Sauce;
using FactoryBuilder.Ingredients.Veggie;
using FactoryBuilder.Ingredients.Pepperoni;

namespace FactoryBuilder.PizzaIngridientFactory
{
    public interface IPizzaIngridientFactory
    {
        ICheese CreateCheese();
        IClams CreateClams();
        IDough CreateDough();
        ISauce CreateSause();
        List<IVeggie> CreateVeggie();
        IPepperoni CreatePepperoni();
    }
}
