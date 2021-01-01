using System;
using PizzaStore.Domain.Pizzas.Abstract;

namespace PizzaStore.Domain.Pizzas.RegionalPizzas.NyStyle
{

    public class NyStyleClamPizza : Pizza
    {
        public NyStyleClamPizza()
        {
            Console.WriteLine("Starting the NY Style Clam Za'");
        }
    }
}
