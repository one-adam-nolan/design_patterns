using System;
using PizzaStore.Domain.Pizzas.Abstract;

namespace PizzaStore.Domain.Pizzas.RegionalPizzas.NyStyle
{

    public class NyStylePepperoniPizza : Pizza
    {
        public NyStylePepperoniPizza()
        {
            Console.WriteLine("Starting the NY Style Pepperoni Za'");
        }
    }
}
