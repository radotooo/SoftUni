using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<int, int> result = new Dictionary<int, int>();

            for (int i = 0; i < num; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (!result.ContainsKey(input))
                {
                    result[input] = 1;
                }
                else
                {
                    result[input]++;
                }

            }
            foreach (var numm in result.OrderBy(x => x.Value))
            {
                if (numm.Value % 2 == 0)
                {
                    Console.WriteLine(numm.Key);
                    break;
                }
            }

        }
    }
}