using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] task = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] gg = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int numsToPush = task[0];
            int numsToPop= task[1];
            int num = task[2];

            Stack<int> numsGivven = new Stack<int>();

            for (int i = 0; i < numsToPush; i++)
            {
                numsGivven.Push(gg[i]);
            }

            for (int i = 0; i < numsToPop; i++)
            {
                numsGivven.Pop();
            }
            if (numsGivven.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
                if(numsGivven.Contains(num))
            {
                Console.WriteLine("true");
                return;
            }
            else
            {
                Console.WriteLine(numsGivven.Min());
            }



        }
    }
}
