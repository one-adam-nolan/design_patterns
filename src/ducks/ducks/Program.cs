using System;
using ducks.objects.ducks;

namespace ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            RunDuckBehaviors(new MallardDuck());

            RunDuckBehaviors(new RubberDuck());

            Console.ReadLine();
        }

        private static void RunDuckBehaviors(Duck duck)
        {
            duck.Display();

            duck.PerformQuack();

            duck.PerformFly();
        }
    }
}
