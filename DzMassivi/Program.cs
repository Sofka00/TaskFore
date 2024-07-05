using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzMassivi
{
    internal class Program
    {
        private static int GetHighestRating(int[] ratings) //дз 4 
        {
            if (ratings == null || ratings.Length == 0) 
            {
                throw new ArgumentException("не может быть пустым");
            }
            int maxRatings = ratings[0];
            for (int i = 1; i < ratings.Length; i++)
            {
                if (ratings[i] > maxRatings)
                {
                    maxRatings = ratings[i];
                }
            }
            return maxRatings;
        }
        private static decimal[] CalculatePrice(decimal[] price)
        {
            if (price == null || price.Length == 0)
            {
                Console.WriteLine("Не может быть пустым");
            }
            decimal markup = 1.0m + 18.0m / 100.0m; 
            decimal[] fullPrice = new decimal[price.Length];
            for (int i = 0; i < price.Length; i++)
            {
                fullPrice[i] = price[i] * markup;
            }
            return fullPrice;

        }
        private static void PrintPrices(decimal[] prices)
        {
            foreach (decimal price in prices)
            {
                Console.WriteLine(price);
            }
        }
        private static int SalesSystem(decimal[] employeSales, decimal plan)
        {
            int amountNotComplyt = 0;
            foreach (var sales in employeSales)
            {
                if (sales < plan)
                {
                    amountNotComplyt++;
                }
            }
            return amountNotComplyt;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetHighestRating(new int[] {60,10,100}));
            Console.ReadLine();

            decimal[] prices = { 100m, 200m, 300m };
            decimal[] fullPrices = CalculatePrice(prices);
            PrintPrices(fullPrices);

            Console.ReadLine();

            Console.WriteLine(SalesSystem(new decimal[] {1000,100}, 1000m));
            Console.ReadLine();
        }


    }
}
