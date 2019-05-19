using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            var result = new Stack<int>();
            for (int i = 0; i < queries; i++)
            {
                int[] commands = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if(commands[0]==1)
                {
                    result.Push(commands[1]);
                }
                else if (commands[0] == 2)
                {
                    if (result.Count > 0 )
                    {
                        result.Pop();
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (commands[0]==3&& result.Count > 0)
                {
                    Console.WriteLine(result.Max());
                }
                else if(commands[0]==4&& result.Count > 0)
                {
                    Console.WriteLine(result.Min());
                }
            }

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
