using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(new char[] { ',', ' '}, options: StringSplitOptions.RemoveEmptyEntries).ToArray();

            var result = numbers.Select(int.Parse).Where(x => x % 2 == 0).OrderBy(c=>c).ToList();
            Console.WriteLine(string.Join(", ",result));

        }
    }
}
