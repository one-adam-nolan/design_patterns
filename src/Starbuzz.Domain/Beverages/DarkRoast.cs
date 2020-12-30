using Starbuzz.Domain.Abstract;

namespace Starbuzz.Domain.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.Description = "Dark Roast Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
