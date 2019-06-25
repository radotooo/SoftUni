using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());

            int[] collection = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, bool> chekEvenFunc = x => x % 2 == 0;

            var resultEvenn = collection.Where(x => chekEvenFunc(x)).ToArray();
            var resultOdd = collection.Where(x => !chekEvenFunc(x)).ToArray();


            Array.Sort(resultEvenn);
            Array.Sort(resultOdd);





            Console.WriteLine(string.Concat(string.Join(" ", resultEvenn)+" ", string.Join(" ", resultOdd)));

        }
    }
}
