using System;
using PizzaStore.Domain.Pizzas;
using PizzaStore.Domain.Pizzas.Abstract;

namespace PizzaStore.Domain.Stores.Abstract
{
    public abstract class BasePizzaStore
    {
        public Pizza OrderPizza(PizzaTypes pizzaType)
        {
            var pizza = this.CreatePizza(pizzaType);

            pizza.Prepare();

            pizza.Bake();

            pizza.Cut();

            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(PizzaTypes pizzaType);
    }
}
