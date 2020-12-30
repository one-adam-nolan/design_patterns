using System;
using Starbuzz.Domain.Abstract;

namespace Starbuzz.Domain.AddOns
{
    public class Mocha : CondimentDecorator
    {
        private const string MochaTag = ", Mocha";
        private Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return this.beverage.GetDescription() + MochaTag;
        }

        public override decimal Cost()
        {
            return this.beverage.Cost() + .20m;
        }
    }
}
