using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {

            //string test = Console.ReadLine();
           

            string[] names = Console.ReadLine().Split().ToArray();
            int digit = int.Parse(Console.ReadLine());



            Queue<string> bb = new Queue<string>();
            for (int i = 0; i < names.Length; i++)
            {
                bb.Enqueue(names[i]);
            }

            while (bb.Count>1)
            {

                for (int i = 0; i < digit-1; i++)
                {
                    string current = bb.Peek();
                    bb.Dequeue();
                    bb.Enqueue(current);
                }
                Console.WriteLine( $"Removed {bb.Dequeue()}" );

            }
            Console.WriteLine($"Last is {bb.Dequeue()}");
        }
    }
}
