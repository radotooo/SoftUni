using System;
using System.Linq;

namespace _03.Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());



            int[,] matrix = new int[input, input];
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
            int diagonalSum = 0;
            for (int h = 0; h < numRows; h++)
            {
                diagonalSum += matrix[h, h];
            }
            Console.WriteLine(diagonalSum);
        }
    }
}
