using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            FillingTheMatrix(matrix);

            int[,] insideMatrix = new int[3, 3];



            int currentSum = 0;
            int sum = 0;

            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int g = 0; g < matrix.GetLength(1) - 2; g++)
                {


                    currentSum = matrix[i, g] + matrix[i, g + 1] + matrix[i, g + 2]
                                 + matrix[i + 1, g] + matrix[i + 1, g + 1] + matrix[i + 1, g + 2]
                                 + matrix[i + 2, g] + matrix[i + 2, g + 1] + matrix[i + 2, g + 2];
                    if (currentSum > sum)
                    {
                        sum = currentSum;
                        currentSum = 0;
                        insideMatrix[0, 0] = matrix[i, g];
                        insideMatrix[0, 1] = matrix[i, g + 1];
                        insideMatrix[0, 2] = matrix[i, g + 2];
                        insideMatrix[1, 0] = matrix[i + 1, g];
                        insideMatrix[1, 1] = matrix[i + 1, g + 1];
                        insideMatrix[1, 2] = matrix[i + 1, g + 2];
                        insideMatrix[2, 0] = matrix[i + 2, g];
                        insideMatrix[2, 1] = matrix[i + 2, g + 1];
                        insideMatrix[2, 2] = matrix[i + 2, g + 2];

                    }

                }

            }
            Console.WriteLine($"Sum = {sum}");
            for (int i = 0; i < 3; i++)
            {

                Console.Write(insideMatrix[i, 0] + " " + insideMatrix[i, 1] + " " + insideMatrix[i, 2]);
                Console.WriteLine();
            }
        }

        private static void FillingTheMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int g = 0; g < matrix.GetLength(1); g++)
                {
                    matrix[i, g] = input[g];

                }
            }
        }
    }

}
            



















