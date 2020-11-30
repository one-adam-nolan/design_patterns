using System;
using ducks.objects.Interfaces;

namespace ducks.objects.Behaviors.Fly
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Flying with Wingy-es");
        }
    }
}
