using System;
using System.Linq;

namespace _02.Sum_Matrix_Columns
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
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int h = 0; h < numCols; h++)
                {
                    matrix[i, h] = nums[h];

                }
            }
            int rowsSum = 0;
            for (int i = 0; i < numCols; i++)
            {
                for (int h = 0; h < numRows; h++)
                {
                    rowsSum += matrix[h, i];
                }
                Console.WriteLine(rowsSum);
                rowsSum = 0;
            }

        }
    }
}
