using System;
using ducks.objects.Interfaces;

namespace ducks.objects.Behaviors.QuackBehavior
{
    public class QuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack!");
        }
    }
}
