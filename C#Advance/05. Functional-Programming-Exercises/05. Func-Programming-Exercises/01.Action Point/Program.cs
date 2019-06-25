using System;
using System.Linq;

namespace _01.Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printResult = x => Console.WriteLine(x);

            Console.ReadLine().Split().ToList().ForEach(printResult);


            
        }
    }
}
