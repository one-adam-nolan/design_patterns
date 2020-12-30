using System;
using Starbuzz.Domain.Abstract;
using Starbuzz.Domain.AddOns;
using Starbuzz.Domain.Beverages;

namespace Starbuzz.App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello world?");

            var baseExpress = new Expresso();

            Console.WriteLine($"{baseExpress.GetDescription()} ${baseExpress.Cost()}");

            var darkRoast = new DarkRoast() as Beverage;

            darkRoast = new Mocha(darkRoast);

            darkRoast = new Mocha(darkRoast);

            darkRoast = new Whip(darkRoast);

            Console.WriteLine($"{darkRoast.GetDescription()} ${darkRoast.Cost()}");

            var houseBlend = new HouseBlend() as Beverage;

            houseBlend = new Soy(houseBlend);

            houseBlend = new Mocha(houseBlend);

            houseBlend = new Whip(houseBlend);

            Console.WriteLine($"{houseBlend.GetDescription()} ${houseBlend.Cost()}");
        }
    }
}
