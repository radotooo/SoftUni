using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Working_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> result = new Queue<int>();
            foreach (var item in input.Where(x=>x %2==0))
            {
                result.Enqueue(item);
                
            }

            
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
