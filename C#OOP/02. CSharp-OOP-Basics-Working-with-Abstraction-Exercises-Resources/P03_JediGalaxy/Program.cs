using System;
using System.Linq;

namespace P03_JediGalaxy
{
    class Program
    {
        static void Main()
        {
            int[] dimestions = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int x = dimestions[0];
            int y = dimestions[1];

            int[,] matrix = new int[x, y];

            int value = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix[i, j] = value++;
                }
            }

            string command = Console.ReadLine();
            long sum = 0;
            while (command != "Let the Force be with you")
            {
                int[] ivoS = command.Split().Select(int.Parse).ToArray();
                int[] evil = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int xEvil = evil[0];
                int yEvil = evil[1];

                while (xEvil >= 0 && yEvil >= 0)
                {
                    if (chekIfIsIn(matrix, xEvil, yEvil))
                    {

                        matrix[xEvil, yEvil] = 0;
                    }
                   
                    xEvil--;
                    yEvil--;
                }

                int xIvan = ivoS[0];
                int yIvan = ivoS[1];

                while (xIvan >= 0 && yIvan < matrix.GetLength(1))
                {
                    if (chekIfIsIn(matrix, xIvan, yIvan))
                    {
                        sum += matrix[xIvan, yIvan];
                    }
                       
                    

                    yIvan++;
                    xIvan--;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);

        }

        private static bool chekIfIsIn(int[,] matrix, int xEvil, int yEvil)
        {
            return xEvil >= 0 && xEvil < matrix.GetLength(0) && yEvil >= 0 && yEvil < matrix.GetLength(1);
        }
            
    }
}
