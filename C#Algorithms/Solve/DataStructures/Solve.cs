using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class Solve
    {
        public static string SumAndAverage(int[] input)
        {
            if (input.Length == 0)
            {
                return $"Sum={0}; Average={0:F2}";

            }
            return $"Sum={input.Sum()}; Average={input.Average():F2}";
        }

        public static void LongestSubsequense(int[] input)
        {

            var longestSequence = new List<int>();
            var currentSequence = new List<int>();



            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        currentSequence.Add(input[j]);

                    }
                    else
                    {
                        break;
                    }
                }
                if (currentSequence.Count > longestSequence.Count)
                {
                    longestSequence = currentSequence.Select(x => x).ToList();
                }
                currentSequence.Clear();

            }


            Console.WriteLine(string.Join(" ", longestSequence));




        }


    }
}
