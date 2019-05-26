using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            SortedSet<string> result = new SortedSet<string>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                for (int g = 0; g < input.Length; g++)
                {
                    result.Add(input[g]);
                }
            }
            Console.WriteLine(string.Join(" ",result));

        }
    }
}
