using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = num[0];
            int m = num[1];

            HashSet<int> firstHash = new HashSet<int>();
            HashSet<int> secondHash = new HashSet<int>();

            fillingHash(firstHash, n);
            fillingHash(secondHash, m);

            HashSet<int> result = new HashSet<int>(firstHash);

            result.IntersectWith(secondHash);
            Console.WriteLine(string.Join(" ",result));




        }

        private static void fillingHash(HashSet<int> firstHash, int n)
        {
            for (int i = 0; i < n; i++)
            {
                firstHash.Add(int.Parse(Console.ReadLine()));

            }
        }
    }
}
