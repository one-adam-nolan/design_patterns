using System;
using PizzaStore.Domain.Pizzas;
using PizzaStore.Domain.Pizzas.Abstract;
using PizzaStore.Domain.Pizzas.BaseTypes;

namespace PizzaStore.Domain.Factories
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(PizzaTypes pizzaType)
        {
            Pizza pizza;

            switch (pizzaType)
            {
                case PizzaTypes.Cheese:
                    pizza = new CheesePizza();
                    break;
                case PizzaTypes.Pepperoni:
                    pizza = new PepperoniPizza();
                    break;
                case PizzaTypes.Clam:
                    pizza = new ClamPizza();
                    break;
                case PizzaTypes.Veggie:
                    pizza = new VeggiePizza();
                    break;
                default:
                    throw new NotImplementedException($"Not Pizza type for {pizzaType}");
            }

            return pizza;
        }
    }
}
