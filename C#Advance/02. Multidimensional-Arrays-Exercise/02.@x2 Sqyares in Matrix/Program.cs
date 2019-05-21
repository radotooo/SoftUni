using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._x2_Sqyares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[matrixSize[0], matrixSize[1]];

            FillingTheMatrix(matrix);
            int equalCells = FindEqualCells(matrix);
            Console.WriteLine(equalCells);

        }

        private static int FindEqualCells(char[,] matrix)
        {
            int count = 0;
            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {
                for (int h = 0; h < matrix.GetLength(1)-1; h++)
                {
                    if(matrix[i,h] == matrix[i,h+1] && matrix[i, h] == matrix[i+1,h] && matrix[i, h] == matrix[i+1,h+1])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        private static void FillingTheMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int g = 0; g < matrix.GetLength(1); g++)
                {
                    matrix[i, g] = char.Parse(input[g]);
                    
                }
            }

        }
    }
}



