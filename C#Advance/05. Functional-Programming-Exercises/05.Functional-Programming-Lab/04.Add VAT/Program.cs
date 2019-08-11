using System;
using System.Linq;

namespace _04.Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double,double> addVat = x => x*1.2 ;

            double[] nums = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .Select(addVat)
                 .ToArray();

            foreach (var num in nums)
            {
                Console.WriteLine($"{num:F2}");
            }
        }
    }
}
