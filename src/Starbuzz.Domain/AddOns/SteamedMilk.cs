using Starbuzz.Domain.Abstract;

namespace Starbuzz.Domain.AddOns
{
    public class SteamedMilk : CondimentDecorator
    {
        private const string SteamedMilkTag = ", Steamed Milk";

        private Beverage beverage;

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override decimal Cost()
        {
            return this.beverage.Cost() + .10m;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + SteamedMilkTag;
        }
    }
}
