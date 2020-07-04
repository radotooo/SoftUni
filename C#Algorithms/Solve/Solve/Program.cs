using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Solve
{
    class Program
    {

        static void Main(string[] args)
        {
            var world = new char[][]
            {
            new char[] {'#', '#', '#' },
            new char[] {'#', '#', '#','.','#'},
            new char[] {'#', '#', '#' },
            };
            var firstInfected = new int[] { 1, 1 };

            var firstInfecterRow = firstInfected[0];
            var firstInfecterCol = firstInfected[1];

            world[firstInfecterRow][firstInfecterCol] = 'I';

            var infected = new Dictionary<Tuple<int,int>, int>();
            //PrintMatrix(world);

            int days = 1;
            infected[new Tuple<int,int>(firstInfecterRow, firstInfecterCol)] = days;

           

           // var result = Codenavirus(world, firstInfected);
           

            while (true)
            {

                //if (AllInfected(world))
                //{
                //   var result  =  CountResults(world,days);
                //    Console.WriteLine(string.Join(",", result));
                //    return;
                //}

                for (int row = 0; row < world.Length; row++)
                {
                    for (int col = 0; col < world[row].Length; col++)
                    {
                        var coords = new Tuple<int,int>(row, col );
                      //  Console.WriteLine($"{coords.Item1} {coords.Item2}");
                   
                        if(infected.Keys.Any(x=>x.Item1 == coords.Item1 && x.Item2 == coords.Item2))
                        {
                            var daysPassOfInfection = days - infected[coords];
                            if (daysPassOfInfection > 2)
                            {
                                world[row][col] = 'R';
                            }
                            else if (daysPassOfInfection == 1 || daysPassOfInfection == 2)
                            {
                                if (chekAndInfect(world, row, col + 1))
                                 {

                                    infected[new Tuple<int, int>(row, col+1)] = days;
                                }

                                else if (chekAndInfect(world, row - 1, col))
                                {

                                    infected[new Tuple<int, int>(row-1, col)] = days;


                                }

                                else if (chekAndInfect(world, row, col - 1))
                                {

                                    infected[new Tuple<int, int>(row, col - 1)] = days;


                                }

                                else if (chekAndInfect(world, row + 1, col))
                                {

                                    infected[new Tuple<int, int>(row + 1, col)] = days;


                                }
                               
                            }
                           
                        }

                    }
                }
                if (AnyInfectedCanSpreadToxic(infected, days))
                {
                    var result = CountResults(world, days);
                    Console.WriteLine(string.Join(",", result));
                    return;

                }

                PrintMatrix(world);
                Console.WriteLine($" DAYS : {days}");
                days++;
                
               

            }



        }

        private static bool AnyInfectedCanSpreadToxic(Dictionary<Tuple<int, int>, int> infected,int days)
        {
            var result = infected.All(x => (days - x.Value) > 0);
            return result;
        }

        private static int[] CountResults(char[][] world,int days)
        {
            
            var infected = 0;
            var recovered = 0;
            var uninfected = 0;

            for (int row = 0; row < world.Length; row++)
            {
                for (int col = 0; col < world[row].Length; col++)
                {
                    if (world[row][col] == 'I')
                    {
                        infected++;
                    }
                    else if(world[row][col] == '#')
                    {
                        uninfected++;
                    }
                    else if(world[row][col] == 'R')
                    {
                        recovered++;
                    }
                }
            }
            return new int[] { days, infected, recovered, uninfected };

        }

        private static bool AllInfected(char[][] world)
        {
            foreach (var row in world)
            {
                if (row.Contains('#'))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool chekAndInfect(char[][] matrix, int row , int col)
        {
            if (OutsideOfMatrix(matrix, row, col))
            {
                return false;
            }

            if (matrix[row][col] == '#')
            {
                matrix[row][col] = 'I';
               
                return true;
            }
            
            return false;

        }

        public static int[] Codenavirus(char[][] world, int[] firstInfected)
        {
            //a: number of days until the virus stops spreading
            //b: number of infected people at the end of the spread
            //c: number of recovered people at the end
            //d : number of uninfected people




            return null;

        }
        //public void solve(char[][] world, int row, int col)
        //{
        //    world[row][col] = 0;
        //    if (OutsideOfMatri(world, row, col))
        //    {
        //        return;
        //    }
        //    if (world[row][col] == 1)
        //    {

        //    }




        //}

        public static bool OutsideOfMatrix(char[][] world, int row, int col)
        {
            if (row < 0 || row >= world.GetLength(0))
            {
                return true;
            }

            if (col < 0 || col >= world.Length)
            {
                return true;
            }
            return false;

        }



        //public static int[][] ConvertCharMatrixToIntMatrix(char[][] world)
        //{
        //    var intMatrix = new int[world.GetLength(0)][];


        //    for (int row = 0; row < world.GetLength(0); row++)
        //    {
        //        var rowLength = world[row].Length;

        //        intMatrix[row] = new int[rowLength];

        //        for (int col = 0; col < rowLength; col++)
        //        {
        //            if(world[row][col] == '#')
        //            {
        //                intMatrix[row][col] = 0;
        //            }
        //            else
        //            {
        //                intMatrix[row][col] = -1;
        //            }

        //        }

        //    }
        //    return intMatrix;

        //}
        public static void PrintMatrix(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(",", row));
            }

        }
        #region Solved Tasks
        public static void Map()
        {
            var a = int.Parse(Console.ReadLine());
            var map = new Dictionary<string, string>();
            for (int i = 0; i < a; i++)
            {
                var input = Console.ReadLine().Split();

                map[input[0]] = input[1];
            }
            string queryKey;
            while ((queryKey = Console.ReadLine()) != null)
            {
                if (map.ContainsKey(queryKey))
                {
                    Console.WriteLine("{0}={1}", queryKey, map[queryKey]);
                }
                else
                {
                    Console.WriteLine("Not found");
                }


            }


        }
        public static int CountBits(int n)
        {
            return Convert.ToString(n, 2).ToArray().Count(x => x == 1);
        }
        static int factorial(int n)
        {
            if (n < 1)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }
        static void Binary(int n)
        {
            string binaryNum = Convert.ToString(n, 2);
            var result = Regex.Matches(binaryNum, @"(1)*").OfType<Match>().Select(match => match.Value).OrderByDescending(length => length).ToArray()[0].Count();

            Console.WriteLine(result);

        }
        static void ShiftMatrix(int[,] matrix)
        {
            var size = matrix.GetLength(0);
            var result = new int[size, size];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int g = 0; g < matrix.GetLength(1); g++)
                {

                    result[g, matrix.GetLength(0) - 1 - i] = matrix[i, g];
                }
            }

            for (int i = 0; i < result.GetLength(0); i++)
            {

                for (int h = 0; h < result.GetLength(1); h++)
                {
                    Console.Write(result[i, h]);
                }
                Console.WriteLine();

            }
        }
        #endregion

    }
}
// var currentCell = world[row][col];

// if (currentCell == '3')
// {
//     world[row][col] = 'R';



// }
//else if (currentCell == '0')
// {
//     world[row][col] = '1';
// }

// else if (currentCell == '2')
// {

//         world[row][col] = '3';

//     if (chekAndInfect(world, row, col+1))
//     {


//     }

//     else if (chekAndInfect(world, row - 1, col))
//     {


//     }

//     else if (chekAndInfect(world, row, col - 1))
//     {


//     }

//    else  if (chekAndInfect(world, row+1, col))
//     {


//     }
//     else
//     {
//        // inf1 = false;
//     }



// }
// else  if (currentCell == '1')
// {
//     world[row][col] = '2';

//     //var right = chekAndInfect(world, row, col + 1);
//     //var top = chekAndInfect(world, row - 1, col);
//     //var left = chekAndInfect(world, row, col - 1);
//     //var bottom = chekAndInfect(world, row-1, col);


//     if (chekAndInfect(world, row, col + 1))
//     {


//     }

//     else if (chekAndInfect(world, row - 1, col))
//     {


//     }

//     else if (chekAndInfect(world, row, col - 1))
//     {


//     }

//     else if (chekAndInfect(world, row + 1, col))
//     {


//     }
//     else
//     {
//        // inf2 = false;

//     }






// }
