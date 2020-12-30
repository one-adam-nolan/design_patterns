using Starbuzz.Domain.Abstract;

namespace Starbuzz.Domain.AddOns
{
    public class Whip : CondimentDecorator
    {
        private const string WhipTag = ", Whip";

        private Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override double Cost()
        {
            return this.beverage.Cost() + .10;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + WhipTag;
        }
    }
}
