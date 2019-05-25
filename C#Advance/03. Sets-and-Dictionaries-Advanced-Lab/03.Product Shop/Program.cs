using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var productShops = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(",").ToArray();

                string shop = input[0];
                if (shop == "Revision")
                {
                    break;
                }

                string product = input[1];
                double price = double.Parse(input[2]);

                FillingTheDictionary(productShops, shop, product, price);


            }
                PrintingResults(productShops);


        }

        private static void PrintingResults(Dictionary<string, Dictionary<string, double>> productShops)
        {
            foreach (var shops in productShops.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{shops.Key}->");
                foreach (var products in shops.Value)
                {
                    Console.WriteLine($"Product:{products.Key}, Price: {products.Value}");
                }
            }
        }

        private static void FillingTheDictionary(Dictionary<string, Dictionary<string, double>> productShops, string shop, string product, double price)
        {
            if (!productShops.ContainsKey(shop))
            {
                productShops[shop] = new Dictionary<string, double>();



            }

            if (!productShops[shop].ContainsKey(product))
            {
                productShops[shop][product] = price;
            }
            else
            {
                productShops[shop][product] = price;
            }
        }
    }
}
