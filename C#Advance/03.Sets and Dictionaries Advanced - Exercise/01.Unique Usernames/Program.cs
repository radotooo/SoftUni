using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < num; i++)
            {
                names.Add(Console.ReadLine());
               
            }
          
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
