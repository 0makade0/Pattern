using System;
namespace Template_method
{
    public class Tea:CaffeineBeverage
    {
        private readonly bool _answerForCondiments;

        public Tea(bool answer)
        {
            _answerForCondiments = answer;
        }
        protected override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        protected override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }

        protected override bool CustomerWantsCondiments()
        {
            return _answerForCondiments;
        }
    }
}