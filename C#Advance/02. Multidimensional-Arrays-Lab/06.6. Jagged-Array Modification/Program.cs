using System;
using System.Linq;

namespace _06._6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int[,] matrix = new int[input, input];


            int rows = matrix.GetLength(0);
            int colums = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int h = 0; h < colums; h++)
                {
                    matrix[i, h] = nums[h];
                }

            }
            while (true)
            {
                string[] commands = Console.ReadLine().Split().ToArray();
                string operation = commands[0];
                if (operation == "END")
                {
                    break;
                }

               else if (operation == "Subtract")
                {
                    int row = int.Parse(commands[1]);
                    
                    int col = int.Parse(commands[2]);
                    if (row >= rows || col >= colums || row < 0 || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                    int num = int.Parse(commands[3]);

                    matrix[row, col] -= num;
                    
                }
                else
                {
                    int row = int.Parse(commands[1]);
                    int col = int.Parse(commands[2]);
                    int num = int.Parse(commands[3]);
                    if (row >= rows || col >= colums|| row <0 || col<0)
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                    matrix[row, col] += num;
                }

            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.WriteLine();
                
            }

        }
    }
}
