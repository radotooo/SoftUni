using System;
using System.Linq;

namespace _02.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Func<string,int> parser = n => int.Parse(n);

            int[] number = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(parser).ToArray();

            Console.WriteLine(number.Length);
            Console.WriteLine(number.Sum());

        }
    }
}
