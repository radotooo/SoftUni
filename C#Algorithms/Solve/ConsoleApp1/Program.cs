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
    }
}
