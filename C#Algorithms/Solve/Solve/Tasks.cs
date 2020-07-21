using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Solve
{
    public class Tasks
    {
       

        //example 
        //count = 2 
        //result: 1 1 
        //        1 2 
        //        2 1 
        //        2 2
        public static void NestedLoopsToRecursion(int count, int index,int[] result )
        {

            if (index == count)
            {
                Console.WriteLine(string.Join(" ", result));
                return;
            }
            for (int i = 1; i <= count; i++)
            {
                result[index] = i;
                NestedLoopsToRecursion(count, index + 1,result);
            }
        }
        public static void ReverseArrayRecursive(int[] arr, int index)
        {
            var currentElement = 0;

            if (index < 0)
            {
                Console.WriteLine(string.Join(" ", arr));
                return;
            }
            else
            {
                currentElement = arr[index];

                arr[index] = arr[arr.Length - 1 - index];

                arr[arr.Length - 1 - index] = currentElement;


                ReverseArrayRecursive(arr, index - 1);
            }

        }
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
    }
}
