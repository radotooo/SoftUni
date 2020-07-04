using System;
using System.Collections.Generic;
using System.Linq;

namespace TestProject
{
    public class Programista
    {
        public int[] Codenavirus(char[][] world, int[] firstInfected)
        {

            var firstInfectetRow = firstInfected[0];
            var firstInfectetCol = firstInfected[1];

            world[firstInfectetRow][firstInfectetCol] = 'I';

            var infected = new Dictionary<Tuple<int, int>, int>();
            int days = 1;
            infected[new Tuple<int, int>(firstInfectetRow, firstInfectetCol)] = days;

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
                                if (IsInsideMatrixAndCanBeInfected(world, row, col + 1))
                                {
                                    infected[new Tuple<int, int>(row, col + 1)] = days;
                                }
                                else if (IsInsideMatrixAndCanBeInfected(world, row - 1, col))
                                {
                                    infected[new Tuple<int, int>(row - 1, col)] = days;
                                }
                                else if (IsInsideMatrixAndCanBeInfected(world, row, col - 1))
                                {
                                    infected[new Tuple<int, int>(row, col - 1)] = days;
                                }
                                else if (IsInsideMatrixAndCanBeInfected(world, row + 1, col))
                                {
                                    infected[new Tuple<int, int>(row + 1, col)] = days;
                                }

                            }

                        }

                    }
                }

                if (IsNoNewInfectedPeople(infected, days))
                {
                    var result = PandemicReport(world, days);
                    return result;
                }
                days++;
            }
        }
        private bool IsNoNewInfectedPeople(Dictionary<Tuple<int, int>, int> infected, int days)
        {
            var result = infected.All(x => (days - x.Value) > 0);
            return result;
        }
        private int[] PandemicReport(char[][] world, int days)
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

        private bool IsInsideMatrixAndCanBeInfected(char[][] matrix, int row, int col)
        {
            if (IsOutsideOfMatrix(matrix, row, col))
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

        private bool IsOutsideOfMatrix(char[][] world, int row, int col)
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
