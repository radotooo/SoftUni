using System;
using System.Linq;

namespace _05._5._Square_with_Maximum_Sum
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
            int maxSum = 0;
            int[,] finalMatrix = new int[2,2];


            for (int i = 0; i < numRows-1; i++)
            {
                for (int h = 0; h < numCols-1; h++)
                {
                    int currentSum = 0;
                    currentSum = matrix[i, h] + matrix[i + 1, h] + matrix[i, h + 1] + matrix[i + 1, h + 1];
                    if(currentSum>maxSum)
                    {
                        maxSum = currentSum;
                        finalMatrix = new int[,] { { matrix[i, h], matrix[i, h + 1] }, { matrix[i + 1, h], matrix[i + 1, h + 1] } };

                    }

                }
            }

           
                Console.Write(finalMatrix[0, 0] +" "+ finalMatrix[0,1]);
            Console.WriteLine();
            Console.Write(finalMatrix[1, 0] + " " + finalMatrix[1, 1]);
            Console.WriteLine();
            Console.WriteLine(maxSum);






        }
    }
}
