using System;
using ducks.objects.Interfaces;

namespace ducks.objects.Behaviors.QuackBehavior
{
    public class MuteQuackBehavoir : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("shhhh....");
        }
    }
}
