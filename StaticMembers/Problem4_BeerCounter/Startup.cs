using System;

namespace Problem4_BeerCounter
{
    public class Startup
    {
        public class BeerCounter
        {
            private static int beerInStock = 0;
            private static int beersDrankCount = 0;

            public static void BuyBeer(int bottlesCount)
            {
                beerInStock += bottlesCount;
            }

            public static void DrinkBeer(int bottlesCount)
            {
                beersDrankCount += bottlesCount;
                beerInStock -= bottlesCount;
            }

            public static int GetBeersInStock()
            {
                return beerInStock;
            }

            public static int GetDrinkedBeers()
            {
                return beersDrankCount;
            }
        }

        public static void Main()
        {
            while (true)
            {
                var inputs = Console.ReadLine().Trim().Split();
                if (inputs[0] == "End")
                {
                    break;
                }

                BeerCounter.BuyBeer(int.Parse(inputs[0]));
                BeerCounter.DrinkBeer(int.Parse(inputs[1]));
            }

            Console.WriteLine(BeerCounter.GetBeersInStock() + " " + BeerCounter.GetDrinkedBeers());
        }
    }
}
