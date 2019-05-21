using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq;

namespace _08.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            if (matrixSize==0)
            {
                Console.WriteLine($"Alive cells: {count}");
                Console.WriteLine($"Sum: {sum}");
                return;
            }

            int[][] matrix = new int[matrixSize][] ;

            for (int i = 0; i < matrixSize; i++)
            {
                 
                matrix[i] = new int[matrixSize];
               matrix[i]= Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();


            }
            List<int> bombs = new List<int>();
            bombs = Console.ReadLine().Split(new char[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (bombs.Count>0)
            {
                int row = bombs[0];
                int col = bombs[1];

                bombs.RemoveAt(0);
                bombs.RemoveAt(0);

                int currentBombPower = matrix[row][col];


                //if(matrix[row][col]>0 )
                //{
              
                //}


                if(col + 1 < matrix.Length  && matrix[row][col+1] > 0 )
                {
                    matrix[row][col + 1] -= currentBombPower;
                }
                if (col - 1 >= 0 && matrix[row][col - 1] > 0  )
                {
                    matrix[row][col - 1] -= currentBombPower;
                }

                
                if (row - 1 >= 0 && matrix[row-1][col] > 0)
                {
                    matrix[row-1][col] -= currentBombPower;
                }
                if (row - 1 >= 0 && col + 1 < matrix.Length && matrix[row -1][col + 1] > 0)
                {
                    matrix[row-1][col + 1] -= currentBombPower;
                }
                if (row - 1 >= 0 && col - 1 >= 0 && matrix[row-1][col - 1] > 0)
                {
                    matrix[row-1][col - 1] -= currentBombPower;
                }

                if (row + 1 < matrix.Length && matrix[row + 1][col] > 0)
                {
                    matrix[row + 1][col] -= currentBombPower;
                }
                if (row + 1 < matrix.Length && col + 1 < matrix.Length &&  matrix[row + 1][col + 1] > 0)
                {
                    matrix[row + 1][col + 1] -= currentBombPower;
                }
                if (row + 1 < matrix.Length && col - 1 >= 0 &&  matrix[row + 1][col - 1] > 0)
                {
                    matrix[row + 1][col - 1] -= currentBombPower;
                }

                matrix[row][col] = 0;

                //if (matrix[row][col + 1] > 0 && col + 1 <= matrixSize - 1 && row + 1 <= matrixSize - 1)
                //{
                //    matrix[row + 1][col + 1] -= currentBombPower;
                //}




            }
            

            for (int i = 0; i < matrixSize; i++)
            {
                for (int h = 0; h < matrixSize; h++)
                {
                    if (matrix[i][h]>0)
                    {
                        sum += matrix[i][h];
                        count++;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(r => string.Join(" ", r))));






            //List<int> bb = new List<int>();
            //bb.Add(5);
            //bb.Add(5);
            //bb.Add(5);
            //bb.Add(5);
            //bb.Add(5);

            //Dictionary<int, int> gg = new Dictionary<int, int>();
            //gg[1] = 1;
            //gg[2] = 1;
            //gg[3] = 1;
            //gg[4] = 1;



            //foreach (var item in matrix)
            //{
            //    Console.WriteLine(string.Join(" ", item));
            //}
        }
    }
}
