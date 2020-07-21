using System;
using TestProject;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var solve = new Programista();
            var world = new char[][]
          {
            new char[] {'#', '#', '#' },
            new char[] {'#', '#', '#'},
            new char[] {'#', '#', '#' },
          };
            var firstInfected = new int[] { 1, 1 };
            var result = solve.Codenavirus(world, firstInfected);

           
            Console.WriteLine(string.Join(",", result));

        }
//        var world = new char[][]
//           {
//            new char[] {'#', '#', '#' },
//            new char[] {'#', '#', '#','.','#'},
//            new char[] {'#', '#', '#' },
//           };
//        var firstInfected = new int[] { 1, 1 };

//        var firstInfecterRow = firstInfected[0];
//        var firstInfecterCol = firstInfected[1];

//        world[firstInfecterRow][firstInfecterCol] = 'I';

//            var infected = new Dictionary<Tuple<int, int>, int>();
//        //PrintMatrix(world);

//        int days = 1;
//        infected[new Tuple<int, int>(firstInfecterRow, firstInfecterCol)] = days;

           

//           // var result = Codenavirus(world, firstInfected);
           

//            while (true)
//            {

//                //if (AllInfected(world))
//                //{
//                //   var result  =  CountResults(world,days);
//                //    Console.WriteLine(string.Join(",", result));
//                //    return;
//                //}

//                for (int row = 0; row<world.Length; row++)
//                {
//                    for (int col = 0; col<world[row].Length; col++)
//                    {
//                        var coords = new Tuple<int, int>(row, col);
//                      //  Console.WriteLine($"{coords.Item1} {coords.Item2}");
                   
//                        if(infected.Keys.Any(x=>x.Item1 == coords.Item1 && x.Item2 == coords.Item2))
//                        {
//                            var daysPassOfInfection = days - infected[coords];
//                            if (daysPassOfInfection > 2)
//                            {
//                                world[row][col] = 'R';
//                            }
//                            else if (daysPassOfInfection == 1 || daysPassOfInfection == 2)
//                            {
//                                if (chekAndInfect(world, row, col + 1))
//                                 {

//                                    infected[new Tuple<int, int>(row, col + 1)] = days;
//                                }

//                                else if (chekAndInfect(world, row - 1, col))
//                                {

//                                    infected[new Tuple<int, int>(row - 1, col)] = days;


//                                }

//                                else if (chekAndInfect(world, row, col - 1))
//                                {

//                                    infected[new Tuple<int, int>(row, col - 1)] = days;


//                                }

//                                else if (chekAndInfect(world, row + 1, col))
//                                {

//                                    infected[new Tuple<int, int>(row + 1, col)] = days;


//                                }
                               
//                            }
                           
//                        }

//                    }
//                }
//                if (AnyInfectedCanSpreadToxic(infected, days))
//                {
//                    var result = CountResults(world, days);
//Console.WriteLine(string.Join(",", result));
//                    return;

//                }

//                PrintMatrix(world);
//Console.WriteLine($" DAYS : {days}");
//                days++;
                
               

//            }



//        }

//        private static bool AnyInfectedCanSpreadToxic(Dictionary<Tuple<int, int>, int> infected, int days)
//{
//    var result = infected.All(x => (days - x.Value) > 0);
//    return result;
//}

//private static int[] CountResults(char[][] world, int days)
//{

//    var infected = 0;
//    var recovered = 0;
//    var uninfected = 0;

//    for (int row = 0; row < world.Length; row++)
//    {
//        for (int col = 0; col < world[row].Length; col++)
//        {
//            if (world[row][col] == 'I')
//            {
//                infected++;
//            }
//            else if (world[row][col] == '#')
//            {
//                uninfected++;
//            }
//            else if (world[row][col] == 'R')
//            {
//                recovered++;
//            }
//        }
//    }
//    return new int[] { days, infected, recovered, uninfected };

//}

//private static bool AllInfected(char[][] world)
//{
//    foreach (var row in world)
//    {
//        if (row.Contains('#'))
//        {
//            return false;
//        }
//    }
//    return true;
//}

//public static bool chekAndInfect(char[][] matrix, int row, int col)
//{
//    if (OutsideOfMatrix(matrix, row, col))
//    {
//        return false;
//    }

//    if (matrix[row][col] == '#')
//    {
//        matrix[row][col] = 'I';

//        return true;
//    }

//    return false;

//}

//public static int[] Codenavirus(char[][] world, int[] firstInfected)
//{
//    //a: number of days until the virus stops spreading
//    //b: number of infected people at the end of the spread
//    //c: number of recovered people at the end
//    //d : number of uninfected people




//    return null;

//}
////public void solve(char[][] world, int row, int col)
////{
////    world[row][col] = 0;
////    if (OutsideOfMatri(world, row, col))
////    {
////        return;
////    }
////    if (world[row][col] == 1)
////    {

////    }




////}

//public static bool OutsideOfMatrix(char[][] world, int row, int col)
//{
//    if (row < 0 || row >= world.GetLength(0))
//    {
//        return true;
//    }

//    if (col < 0 || col >= world.Length)
//    {
//        return true;
//    }
//    return false;

//}



////public static int[][] ConvertCharMatrixToIntMatrix(char[][] world)
////{
////    var intMatrix = new int[world.GetLength(0)][];


////    for (int row = 0; row < world.GetLength(0); row++)
////    {
////        var rowLength = world[row].Length;

////        intMatrix[row] = new int[rowLength];

////        for (int col = 0; col < rowLength; col++)
////        {
////            if(world[row][col] == '#')
////            {
////                intMatrix[row][col] = 0;
////            }
////            else
////            {
////                intMatrix[row][col] = -1;
////            }

////        }

////    }
////    return intMatrix;

////}
//public static void PrintMatrix(char[][] matrix)
//{
//    foreach (var row in matrix)
//    {
//        Console.WriteLine(string.Join(",", row));
//    }

//}
       
    }
}
