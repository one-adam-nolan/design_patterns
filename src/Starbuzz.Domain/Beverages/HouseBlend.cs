using Starbuzz.Domain.Abstract;

namespace Starbuzz.Domain.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.Description = "House Blend Coffee";
        }

        public override decimal Cost()
        {
            return .89m;
        }
    }
}
