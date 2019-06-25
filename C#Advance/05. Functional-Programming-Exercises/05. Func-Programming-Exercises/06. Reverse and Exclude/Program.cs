using System;
using System.Linq;

namespace _06._Reverse_and_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());

            //Predicate<int> removeDevidetByN = x => x % n != 0;
            Func<int, bool> func = x => x % n != 0;



            nums = nums.Where(func).ToArray();
            Console.WriteLine(string.Join(" ",nums.Reverse()));


        }
    }
}
