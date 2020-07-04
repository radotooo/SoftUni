using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    public class Programista
    {
        public  bool AnyInfectedCanSpreadToxic(Dictionary<Tuple<int, int>, int> infected, int days)
        {
            var result = infected.All(x => (days - x.Value) > 0);
            return result;
        }

        public  int[] CountResults(char[][] world, int days)
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
                    else if (world[row][col] == '#')
                    {
                        uninfected++;
                    }
                    else if (world[row][col] == 'R')
                    {
                        recovered++;
                    }
                }
            }
            return new int[] { days, infected, recovered, uninfected };
        }

        public  bool ChekAndInfect(char[][] matrix, int row, int col)
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

        public  int[] Codenavirus(char[][] world, int[] firstInfected)
        {

            var firstInfecterRow = firstInfected[0];
            var firstInfecterCol = firstInfected[1];

            world[firstInfecterRow][firstInfecterCol] = 'I';

            var infected = new Dictionary<Tuple<int, int>, int>();
            int days = 1;
            infected[new Tuple<int, int>(firstInfecterRow, firstInfecterCol)] = days;

            while (true)
            {
                for (int row = 0; row < world.Length; row++)
                {
                    for (int col = 0; col < world[row].Length; col++)
                    {
                        var coords = new Tuple<int, int>(row, col);

                        if (infected.Keys.Any(x => x.Item1 == coords.Item1 && x.Item2 == coords.Item2))
                        {
                            var daysPassOfInfection = days - infected[coords];
                            if (daysPassOfInfection > 2)
                            {
                                world[row][col] = 'R';
                            }
                            else if (daysPassOfInfection == 1 || daysPassOfInfection == 2)
                            {
                                if (ChekAndInfect(world, row, col + 1))
                                {
                                    infected[new Tuple<int, int>(row, col + 1)] = days;
                                }
                                else if (ChekAndInfect(world, row - 1, col))
                                {
                                    infected[new Tuple<int, int>(row - 1, col)] = days;
                                }
                                else if (ChekAndInfect(world, row, col - 1))
                                {
                                    infected[new Tuple<int, int>(row, col - 1)] = days;
                                }
                                else if (ChekAndInfect(world, row + 1, col))
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
                    return result;
                }
                days++;
            }
        }

        public  bool OutsideOfMatrix(char[][] world, int row, int col)
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
    }
}
