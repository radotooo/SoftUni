using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _09.List_OF_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int rangeOfNums = int.Parse(Console.ReadLine());

            List<int> dividers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();

            List<Predicate<int>> predicateList = new List<Predicate<int>>();

            bool divisible = true;

            foreach (var i in dividers)
            {
                predicateList.Add(x=>x % i ==0);
            }

            for (int i = 1; i <= rangeOfNums; i++)
            {
                foreach (var predicate in predicateList)
                {
                    if (!predicate(i))
                    {
                        divisible = false;
                        continue;
                    }
                }

                if (divisible)
                {
                    result.Add(i);
                    
                }

                divisible = true;
            }


            

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
