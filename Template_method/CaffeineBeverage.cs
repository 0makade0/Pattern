using System;

namespace Template_method
{
    public abstract class CaffeineBeverage
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (CustomerWantsCondiments())
            {
                
                addCondiments();
            }
        }

        protected abstract void brew();

        protected abstract void addCondiments();

        private void boilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        
        protected virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}