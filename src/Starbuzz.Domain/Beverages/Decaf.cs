using Starbuzz.Domain.Abstract;

namespace Starbuzz.Domain.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            this.Description = "Decaf Coffee";
        }

        public override decimal Cost()
        {
            return 1.05m;
        }
    }
}
