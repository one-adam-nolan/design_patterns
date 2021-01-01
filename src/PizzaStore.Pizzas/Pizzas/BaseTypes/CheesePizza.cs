using System;

using PizzaStore.Domain.Pizzas.Abstract;

namespace PizzaStore.Domain.Pizzas.BaseTypes
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Console.WriteLine("Starting the Cheese Za'");
        }
    }
}
