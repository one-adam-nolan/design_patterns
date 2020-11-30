using System;
using ducks.objects.Behaviors.Fly;
using ducks.objects.Behaviors.QuackBehavior;

namespace ducks.objects.ducks
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            this.QuackBehavior = new QuackBehavior();
            this.FlyBehavior = new FlyWithWings();

        }

        public override void Display()
        {
            Console.WriteLine("Display the Mallard");
        }
    }
}
