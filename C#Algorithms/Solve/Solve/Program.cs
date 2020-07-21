using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Solve
{
    public class Program
    {
        private static int[] result;

        static void Main(string[] args)
        {

            var elements = int.Parse(Console.ReadLine());
            var count = int.Parse(Console.ReadLine());

            result = new int[count];

            CombinationWithRepetition(elements, count, 0,1);
        }
        public static void CombinationWithRepetition(int elements, int count, int index,int position)
        {

            if (count == index)
            {
                Console.WriteLine(string.Join(" ", result));
               
                return ;
            }
            for (int i = position; i <= elements; i++)
            {
                result[index] = i;
                
                CombinationWithRepetition(elements , count, index + 1 ,i);

            }


        }
    }

}


