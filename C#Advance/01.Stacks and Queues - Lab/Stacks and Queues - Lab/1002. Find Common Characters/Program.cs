using System;
using System.Collections.Generic;
using System.Linq;

namespace _1002._Find_Common_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string>();
            string[] A = new string[] { "bella", "label", "roller" };
            for (int i = 0; i < A.Length; i++)
            {
                input.Add(A[i]);
            }

            bool valid = true;
            var result2 = new List<string>();
            var result3 = new List<string>();

           

            result2 = A[0].Distinct().SelectMany(l => Enumerable.Repeat(l.ToString(), A.Min(x => x.Count(y => y == l)))).ToList();

            Console.WriteLine(string.Join("", result2));

            var result = new List<string>();

            for (int i = 0; i < input[0].Length; i++)
            {
                string letters = input[0][i].ToString();
                for (int h = 1; h < input.Count; h++)
                {
                    if (!input[h].Contains(letters))
                    {
                        valid = false;
                    }
                }
                if (valid)
                {
                    result.Add(letters);
                    for (int j = 1; j < input.Count; j++)
                    {
                        if (input[j].Contains(letters))
                        {
                            int c = input[j].IndexOf(letters);
                            input[j] = input[j].Remove(c, 1);
                        }
                    }
                }
                valid = true;
            }

            Console.WriteLine(string.Join("", result));

            //Dictionary<char, int[]> map = new Dictionary<char, int[]>();
            //string[] A = new string[] { "bella", "label", "roller" };
            //for (int i = 0; i < A.Length; i++)
            //{
            //     foreach (char j in A[i])
            //    {
            //        if (!map.ContainsKey(j))
            //        {
            //            map.Add(j, new int[A.Length]);
            //        }
            //        map[j][i]++;
            //    }
            //}

            //List<string> result = new List<string>();

            //foreach (var kvp in map)
            //{
            //    int[] arr = kvp.Value;
            //    int count = arr[0];
            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i] < count)
            //        {
            //            count = arr[i];
            //        }
            //    }
            //    if (count < 1) continue;
            //    for (int j = 0; j < count; j++)
            //    {
            //        result.Add(kvp.Key.ToString());
            //    }
            //}

        }
    }
}
