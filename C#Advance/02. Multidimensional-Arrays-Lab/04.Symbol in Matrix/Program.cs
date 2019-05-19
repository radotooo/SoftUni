using System;

namespace _04.Symbol_in_Matrix
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
                char[] nums = Console.ReadLine().ToCharArray();
                for (int h = 0; h < numCols; h++)
                {
                    matrix[i, h] = nums[h];

                }
            }
            char symbol = char.Parse(Console.ReadLine());
            for (int i = 0; i < numRows; i++)
            {
                
                for (int h = 0; h < numCols; h++)
                {
                    if(matrix[i, h] == symbol)
                    {
                        Console.WriteLine($"({i}, {h})");
                        return;
                    }

                }
            }
            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
