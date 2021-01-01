using System;
using PizzaStore.Domain.Pizzas.Abstract;

namespace PizzaStore.Domain.Pizzas.RegionalPizzas.NyStyle
{
    public class NyStyleCheesePizza : Pizza
    {
        public NyStyleCheesePizza()
        {
            Console.WriteLine("Starting the NY Style Cheese Za'");
        }
    }
}
