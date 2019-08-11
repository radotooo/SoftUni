using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reverseInput = new Stack<char>();
            
            for (int i = 0; i < input.Length; i++)
            {
                reverseInput.Push(input[i]);
            }

            while (reverseInput.Count>0)
            {
                Console.Write(   reverseInput.Pop());
            }
            //foreach (var item in reverseInput)
            //{
            //    Console.Write(item);
            //}
            Console.WriteLine();
        }
    }
}
