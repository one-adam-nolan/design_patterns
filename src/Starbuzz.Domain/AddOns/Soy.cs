using Starbuzz.Domain.Abstract;

namespace Starbuzz.Domain.AddOns
{
    public class Soy : CondimentDecorator
    {
        private const string SoyTag = ", Soy Milk";

        private Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override decimal Cost()
        {
            return this.beverage.Cost() + .15m;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + SoyTag;
        }
    }
}
