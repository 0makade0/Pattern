namespace Adapter
{
    public class BirdAdapter: IBird
    {
        private readonly Turkey turkey;
        public BirdAdapter(Turkey turkey)
        {
            this.turkey = turkey;
        }
        public void Fly()
        {
            turkey.Fly();
        }

        public void MakeSound()
        {
            turkey.Gobble();
        }
    }
}
