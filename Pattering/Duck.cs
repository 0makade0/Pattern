using System;
using Pattering.Swim;
using Pattering.Fly;
using Pattering.Quack;

namespace Pattering
{
    public abstract class Duck
    {
        private protected IFlyBehavior flyBehavior;
        private protected IQuackBehavior quackBehavior;
        private protected ISwimable swimable;
        
        public Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior, ISwimable swimable)
        {
            this.flyBehavior = flyBehavior;
            this.quackBehavior = quackBehavior;
            this.swimable = swimable;
        }

        public virtual void Display()
        {
            flyBehavior.Fly();
            quackBehavior.Quack();
            swimable.Swim();
        }

        public void Fly()
        {
            flyBehavior.Fly();
        }

        public void Swim()
        {
            swimable.Swim();
        }

        public void Quack()
        {
            quackBehavior.Quack();
        }

        public void Dead()
        {
            Console.WriteLine("Уточка мертва");
            flyBehavior = new NoFly();
            swimable = new NotSwimable();
            quackBehavior = new NoQuack();
        }
    }
}