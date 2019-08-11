using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> result = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if(input== "End")
                {
                    Console.WriteLine($"{result.Count} people remaining.");
                    break;
                }
                if(input=="Paid")
                {
                    while (result.Count>0)
                    {
                        Console.WriteLine(result.Dequeue());
                    }
                    continue;
                }
                result.Enqueue(input);

            }
        }
    }
}
