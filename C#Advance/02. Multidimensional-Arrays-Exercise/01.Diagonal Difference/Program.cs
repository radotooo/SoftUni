using System;
using System.Linq;

namespace _01.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int[,] matrix = new int[matrixSize, matrixSize];
            MatrixFilling(matrix);


            
            
           
            int primarySum = CalculatingPrimaryDiagonalsSum(matrix);
            int secondaryDiagonal = CalculatunSecondaryDiagonal(matrix);


            

            Console.WriteLine(Math.Abs(primarySum-secondaryDiagonal));
           






        }

        private static int CalculatunSecondaryDiagonal(int[,] matrix)
        {
            int secondarySum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                secondarySum += matrix[i, matrix.GetLength(1) - i-1];
            }
            return secondarySum;
        }

        public static int CalculatingPrimaryDiagonalsSum(int[,] matrix)
        {
            int primarySum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primarySum += matrix[i, i];
            }
            return primarySum;
        }

        private static void MatrixFilling(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int h = 0; h < matrix.GetLength(1); h++)
                {
                    matrix[i, h] = input[h];
                }
            }
        }


    }
}