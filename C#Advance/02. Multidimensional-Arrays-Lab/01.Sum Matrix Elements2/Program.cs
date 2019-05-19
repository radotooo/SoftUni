using System;
using System.Linq;

namespace _01.Sum_Matrix_Elements2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

            int[,] matrix = new int[input[0], input[1]];
            int numRows = matrix.GetLength(0);
            int numCols = matrix.GetLength(1);

            for (int i = 0; i < numRows; i++)
            {
                int[] nums = Console.ReadLine().Split(",").Select(int.Parse).ToArray();
                for (int h = 0; h < numCols; h++)
                {
                    matrix[i, h] = nums[h];

                }
            }
            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            int sum = 0;
            foreach (var item in matrix)
            {


                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
