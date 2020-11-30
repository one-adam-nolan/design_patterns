using System;
using ducks.objects.Interfaces;

namespace ducks.objects.Behaviors.QuackBehavior
{
    public class SqueakBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak!");
        }
    }
}
