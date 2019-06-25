using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Predicate<int> chek = x => x % 2 == 0;
            string command = Console.ReadLine();


            //Enumerable.Range(input[0], input[1] - input[0] + 1)
            //   .Where(x => condition == "even" ? isEven(x) : !isEven(x))
            //   .ToList()
            //   .ForEach(result.Add);

            //Console.WriteLine(String.Join(" ", result));

            var result = new List<int>();
            for (int i = range[0]; i <= range[1]; i++)
            {
                if (command=="even")
                {
                    if(chek(i))
                    result.Add(i);

                }
                else
                {
                    if(!chek(i))
                        result.Add(i);

                }

            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
