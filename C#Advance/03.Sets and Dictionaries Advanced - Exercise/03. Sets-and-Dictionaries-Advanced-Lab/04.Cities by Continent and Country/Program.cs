using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var CitiesContinentsAndCountrys = new Dictionary<string, Dictionary<string, List<string>>>();

            int num = int.Parse(Console.ReadLine());


            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string continent = input[0];
                string country = input[1];
                string cities = input[2];

                FillingTheDict(CitiesContinentsAndCountrys, continent, country, cities);
            }

            PrintingResults(CitiesContinentsAndCountrys);


        }

        private static void PrintingResults(Dictionary<string, Dictionary<string, List<string>>> citiesContinentsAndCountrys)
        {
            foreach (var continents in citiesContinentsAndCountrys)
            {
                Console.WriteLine($"{continents.Key}:");
                foreach (var country in continents.Value)
                {
                   Console.Write($"{country.Key} -> ");
                   Console.WriteLine(string.Join(", ",country.Value));
                   
                    
                }
            }
        }
               
                    
                   


        private static void FillingTheDict(Dictionary<string, Dictionary<string, List<string>>> citiesContinentsAndCountrys, string continent, string country, string cities)
        {
            if(!citiesContinentsAndCountrys.ContainsKey(continent))
            {
                citiesContinentsAndCountrys[continent] = new Dictionary<string, List<string>>();
            }

            if(!citiesContinentsAndCountrys[continent].ContainsKey(country))
            {
                citiesContinentsAndCountrys[continent][country] = new List<string>();
                citiesContinentsAndCountrys[continent][country].Add(cities);
            }
            else
            {
                citiesContinentsAndCountrys[continent][country].Add(cities);

            }

        }
    }
}
