using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.Bomb_the_Basement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] target = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixSize[0], matrixSize[1]];

            int row = target[0];
            int col = target[1];
            int power = target[2];

            //matrix[row, col] = 1;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int g = 0; g < matrix.GetLength(1); g++)
                {
                    double distance = Math.Sqrt(Math.Pow(i - row, 2) + Math.Pow(g - col, 2));
                   
                    if (distance <= power)
                    {
                        matrix[i, g] = 1;
                    }
                }
            }


            int counter = 0;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int g   = 0; g < matrix.GetLength(0); g++)
                {
                    if(matrix[g,i]==1)
                    {
                        matrix[g, i] = 0;
                        counter++;
                    }
                }
                for (int z = 0; z < counter; z++)
                {
                    matrix[z, i] = 1;
                }
                counter = 0;
            }


           

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int h = 0; h < matrix.GetLength(1); h++)
                {
                    Console.Write(matrix[i, h]);
                }
                Console.WriteLine();
            }



        }
    }
}
