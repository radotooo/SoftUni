using System;
using System.Linq;

namespace _03.Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> chekSmallestNum = x => x.Min() ;

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Console.WriteLine(chekSmallestNum(nums));

          
        }
    }
}
