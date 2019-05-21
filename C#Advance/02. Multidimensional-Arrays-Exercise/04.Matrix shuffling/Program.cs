using System;
using System.Linq;

namespace _04.Matrix_shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[,] matrix = new string[matrixSize[0], matrixSize[1]];
            FillingMatrix(matrix);

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(command[0]== "END")
                {
                    break;
                }
                else if(command[0] == "swap")
                {
                    if(command.Length!=5)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    else if (int.Parse(command[1]) > matrix.GetLength(0) 
                        || int.Parse(command[2]) > matrix.GetLength(1) 
                        || int.Parse(command[3])>matrix.GetLength(0) 
                        || int.Parse(command[4]) > matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    string curentSymb = matrix[int.Parse(command[1]), int.Parse(command[2])];
                    matrix[int.Parse(command[1]), int.Parse(command[2])] = matrix[int.Parse(command[3]), int.Parse(command[4])];
                    matrix[int.Parse(command[3]), int.Parse(command[4])] = curentSymb;

                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        for (int h = 0; h < matrix.GetLength(1); h++)
                        {
                            Console.Write(matrix[i, h] + " ");
                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                   continue;
                }
                
            }


        }

        private static void FillingMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                    

                for (int g = 0; g < matrix.GetLength(1); g++)
                {
                    matrix[i, g] = input[g];

                }
            }
        }
    }
}
