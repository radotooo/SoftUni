using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            SortedDictionary<char, int> result = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if(!result.ContainsKey(text[i]))
                {
                    result[text[i]] = 1;
                }
                else
                {
                    result[text[i]]++;
                }
            }

            foreach (var symbol in result)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
