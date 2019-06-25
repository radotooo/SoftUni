using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            Func<int, int> operation = null;

            string differentCommands = Console.ReadLine();
            while (differentCommands!="end")
            {
                switch(differentCommands)
                {
                    case "add": operation = x => x + 1;
                        break;
                    case "multiply": operation = x => x * 2;
                        break;
                    case "subtract": operation = x => x - 1;
                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", nums));
                       
                        break;
                }
                 if(differentCommands!="print")
                {
                    nums = nums.Select(operation).ToList();
                }


                differentCommands = Console.ReadLine();
                
            }


        }
    }
}
