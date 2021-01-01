using PizzaStore.Domain.Factories;
using PizzaStore.Domain.Pizzas;
using PizzaStore.Domain.Pizzas.Abstract;

namespace PizzaStore.Domain.Stores
{
    /// <summary>
    /// It's worth noting that this is the "Simple Factory" and it not considered a design pattern.
    /// The book points this out and gives it an honorable mention, but does not consider it a pattern.
    /// </summary>
    public class SimplePizzaStore
    {
        private readonly SimplePizzaFactory factory;

        public SimplePizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public Pizza OrderPizza(PizzaTypes pizzaType)
        {
            var pizza = this.factory.CreatePizza(pizzaType);

            pizza.Prepare();

            pizza.Bake();

            pizza.Cut();

            pizza.Box();

            return pizza;
        }
    }
}
