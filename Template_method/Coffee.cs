using System;

namespace Template_method
{
    public class Coffee:CaffeineBeverage
    {
        private readonly bool _answerForCondiment;

        public Coffee(bool answer)
        {
            _answerForCondiment = answer;
        }
        protected override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }

        protected override void addCondiments()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        protected override bool CustomerWantsCondiments()
        {
            return _answerForCondiment;
        }
    }
}