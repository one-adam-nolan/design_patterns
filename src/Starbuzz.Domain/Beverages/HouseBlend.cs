using Starbuzz.Domain.Abstract;

namespace Starbuzz.Domain.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.Description = "House Blend Coffee";
        }

        public override double Cost()
        {
            return .89;
        }
    }
}
