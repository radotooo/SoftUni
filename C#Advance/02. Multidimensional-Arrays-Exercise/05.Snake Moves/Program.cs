using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string snake = Console.ReadLine();
            char[,] matrix = new char[matrixSize[0], matrixSize[1]];
            Queue<char> charSnake = new Queue<char>();
            foreach (var item in snake)
            {
                charSnake.Enqueue(item);
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int h = 0; h < matrix.GetLength(1); h++)
                {
                    char snakePart = charSnake.Dequeue();
                    matrix[i, h] = snakePart;
                    charSnake.Enqueue(snakePart);
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int h = 0; h < matrix.GetLength(1); h++)
                {
                    Console.Write(matrix[i,h]);
                }
                Console.WriteLine();
            }



        }
    }
}
