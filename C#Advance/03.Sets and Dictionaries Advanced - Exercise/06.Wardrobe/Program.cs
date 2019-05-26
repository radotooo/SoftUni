using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> result = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] {" -> "},StringSplitOptions.RemoveEmptyEntries).ToArray();

                string colour = input[0];

                if(!result.ContainsKey(colour))
                {

                    result[colour] = new Dictionary<string, int>();

                    FillingInsideDict(input, result, colour);
                    
                }
                else
                {
                    FillingInsideDict(input, result, colour);

                }


            }

            string[] chek = Console.ReadLine().Split().ToArray();



            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} clothes:");
                foreach (var item2 in item.Value)
                {
                    
                    Console.Write($"* {item2.Key} - {item2.Value} ");
                    if (item.Key == chek[0] && item2.Key==chek[1])
                    {
                        Console.Write("(found!)");
                    }
                    Console.WriteLine();
                }
            }
        }

        private static void FillingInsideDict(string[] input, Dictionary<string, Dictionary<string, int>> result,string colour)
        {
            string[] dresses = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries).ToArray();
            for (int c = 0; c < dresses.Length; c++)
            {
                string curentDress = dresses[c];
                if (!result[colour].ContainsKey(curentDress))
                {
                    result[colour][curentDress] = 1;
                }
                else
                {
                    result[colour][curentDress]++;
                }

            }

        }
    }
}
