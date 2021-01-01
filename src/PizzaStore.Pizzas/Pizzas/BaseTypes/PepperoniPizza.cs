using System;

using PizzaStore.Domain.Pizzas.Abstract;

namespace PizzaStore.Domain.Pizzas.BaseTypes
{

    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            Console.WriteLine("Starting the Pepperoni Za'");
        }
    }
}
