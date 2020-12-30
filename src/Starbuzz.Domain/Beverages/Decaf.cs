using Starbuzz.Domain.Abstract;

namespace Starbuzz.Domain.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            this.Description = "Decaf Coffee";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }
}
