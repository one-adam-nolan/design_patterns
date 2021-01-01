using System;
using PizzaStore.Domain.Pizzas.Abstract;

namespace PizzaStore.Domain.Pizzas.RegionalPizzas.NyStyle
{

    public class NyStyleVeggiePizza : Pizza
    {
        public NyStyleVeggiePizza()
        {
            Console.WriteLine("Starting the NY Style Veggie Za'");
        }
    }
}
