using System;
using ducks.objects.Interfaces;

namespace ducks.objects.Behaviors.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("NOT FLYING!!");
        }
    }
}
