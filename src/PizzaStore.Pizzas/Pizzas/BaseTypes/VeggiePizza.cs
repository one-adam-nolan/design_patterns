using System;

using PizzaStore.Domain.Pizzas.Abstract;

namespace PizzaStore.Domain.Pizzas.BaseTypes
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza()
        {
            Console.WriteLine("Starting the Veggie Za'");
        }
    }
}
