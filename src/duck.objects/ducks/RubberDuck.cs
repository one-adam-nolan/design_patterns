using System;
using ducks.objects.Behaviors.Fly;
using ducks.objects.Behaviors.QuackBehavior;

namespace ducks.objects.ducks
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            this.FlyBehavior = new FlyNoWay();
            this.QuackBehavior = new SqueakBehavior();
        }

        public override void Display()
        {
            Console.WriteLine("Imma Rubber Duck");
        }
    }
}
