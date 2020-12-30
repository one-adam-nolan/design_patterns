using Starbuzz.Domain.Abstract;

namespace Starbuzz.Domain.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.Description = "Dark Roast Coffee";
        }

        public override decimal Cost()
        {
            return .99m;
        }
    }
}
