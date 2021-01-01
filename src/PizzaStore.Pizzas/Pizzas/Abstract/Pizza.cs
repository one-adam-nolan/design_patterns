using System;

namespace PizzaStore.Domain.Pizzas.Abstract
{
    public abstract class Pizza
    {
        public Pizza()
        {
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing the Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Baking the Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Putting the za' in the box");
        }
    }
}
