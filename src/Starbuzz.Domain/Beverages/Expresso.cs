using System;
using Starbuzz.Domain.Abstract;

namespace Starbuzz.Domain.Beverages
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            this.Description = "Expresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}
