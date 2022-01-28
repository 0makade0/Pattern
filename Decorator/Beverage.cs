namespace Decorator
{
    public abstract class Beverage
    {
        protected string description = "";
        public abstract int Cost();
        public virtual string GetDescription()
        {
            return description;
        }
    }
}