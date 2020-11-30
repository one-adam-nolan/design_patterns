using ducks.objects.Interfaces;

namespace ducks.objects.ducks
{
    public abstract class Duck
    {
        protected IFlyBehavior FlyBehavior { get; set; }

        protected IQuackBehavior QuackBehavior { get; set; }

        public abstract void Display();

        public void PerformFly()
        {
            this.FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            this.QuackBehavior.Quack();
        }
    }
}
