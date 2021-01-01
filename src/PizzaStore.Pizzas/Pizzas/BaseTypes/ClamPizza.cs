using System;

using PizzaStore.Domain.Pizzas.Abstract;

namespace PizzaStore.Domain.Pizzas.BaseTypes
{

    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            Console.WriteLine("Starting the Clam Za'");
        }
    }
}
