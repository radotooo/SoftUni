using System;
using System.Collections.Generic;

namespace _05.Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            HashSet<string> result = new HashSet<string>();
            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                result.Add(name);
            }

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
