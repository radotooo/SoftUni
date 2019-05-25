using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07.SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var guests = new List<string>();
            var vipGuests = new List<string>();


            while (input!="PARTY")
            {

                string pattern = @"^[0 - 9]";

                if(input.Length!=8)
                {
                    continue;
                }

                if(char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    guests.Add(input);
                }
                input = Console.ReadLine();
            }
            input = Console.ReadLine();

            while (input!="END")
            {
                if (input.Length != 8 )
                {
                    continue;
                }

                if (vipGuests.Contains(input))
                {
                    vipGuests.Remove(input);
                }
                else
                {
                    guests.Remove(input);
                }
                input = Console.ReadLine();

            }

            Console.WriteLine(vipGuests.Count+guests.Count);

            PrintResult(vipGuests);
            
            foreach (var vip in guests)
            {
                Console.WriteLine(vip);
            }


        }

        private static void PrintResult(List<string> vipGuests)
        {
            foreach (var vip in vipGuests)
            {
                Console.WriteLine(vip);
            }
        }
    }
}
