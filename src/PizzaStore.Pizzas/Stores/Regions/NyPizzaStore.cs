using System;
using PizzaStore.Domain.Pizzas;
using PizzaStore.Domain.Pizzas.Abstract;
using PizzaStore.Domain.Pizzas.RegionalPizzas.NyStyle;
using PizzaStore.Domain.Stores.Abstract;

namespace PizzaStore.Domain.Stores.Regions
{
    public class NyPizzaStore : BasePizzaStore
    {
        public NyPizzaStore()
        {
        }

        protected override Pizza CreatePizza(PizzaTypes pizzaType)
        {
            Pizza pizza;

            switch (pizzaType)
            {
                case PizzaTypes.Cheese:
                    pizza = new NyStyleCheesePizza();
                    break;
                case PizzaTypes.Pepperoni:
                    pizza = new NyStylePepperoniPizza();
                    break;
                case PizzaTypes.Clam:
                    pizza = new NyStyleClamPizza();
                    break;
                case PizzaTypes.Veggie:
                    pizza = new NyStyleVeggiePizza();
                    break;
                default:
                    throw new NotImplementedException($"Not Pizza type for {pizzaType}");
            }

            return pizza;
        }
    }
}
