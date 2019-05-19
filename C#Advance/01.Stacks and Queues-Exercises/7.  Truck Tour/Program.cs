using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.__Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {

            int valueOfN = int.Parse(Console.ReadLine());
            List<int[]> pump = new List<int[]>();
            Queue<int[]> gg = new Queue<int[]>();

            for (int i = 0; i < valueOfN; i++)
            {
                int[] pumpa = Console.ReadLine().Split().Select(int.Parse).ToArray();

                pump.Add(pumpa);
                gg.Enqueue(pumpa);

            }


            int gorivo = 0;
            int rastoqnie = 0;
            int total = 0;
            int bestPosition = 0;


            for (int i = 0; i < valueOfN; i++)
            {
                int[] rado = new int[2];
                rado = gg.Peek();

                 gorivo = rado[0];
                 rastoqnie = rado[1];

                total += gorivo;

                if(total>=rastoqnie)
                {
                    total -= rastoqnie;
                }
                else
                {
                    total = 0;
                    bestPosition = i + 1;
                }
                gg.Dequeue();
               
            }
            Console.WriteLine(bestPosition);
            
        }
    }
}




