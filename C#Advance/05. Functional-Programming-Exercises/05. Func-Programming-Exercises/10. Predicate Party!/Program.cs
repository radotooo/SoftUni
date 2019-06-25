using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();
            var result = new List<string>();

            Func<string,bool> operation ;
            Predicate<string> gg;

            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string command = input[0];
                if(command=="Party!")
                {

                    break;
                }
                string criteria = input[1];


                switch (criteria)
                {
                    case "StartsWith": operation = x => x.StartsWith(input[2]);
                        gg = x => x.StartsWith(input[2]);

                        break;
                    case "EndsWith": operation = x => x.EndsWith(input[2]);
                        gg = x => x.EndsWith(input[2]);
                        break;
                    
                    default:
                        operation = x => x.Length == int.Parse(input[2]);
                        gg = x => x.Length == int.Parse(input[2]);

                        break;
                }

                if( command=="Double")
                {
                    result = guests.Where(operation).ToList();
                    foreach (var item in result)
                    {
                        int index = guests.IndexOf(item);
                        guests.Insert(index + 1, item);
                    }
                }
                else if (command == "Remove") 
                {
                    //result = guests.Where(operation).ToList();
                    guests.RemoveAll(gg);
                    //if(result.Count>0)
                    //{
                    //    foreach (var item in result)
                    //    {
                    //        if(guests.Contains(item))
                    //        {
                    //            guests.Remove(item);
                    //        }
                    //    }
                    //}
                    //result.Clear();
                }

            }

            if(guests.Count>0)
            {
                Console.WriteLine($"{string.Join(", ", guests)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }

            //foreach (var item in guests)
            //{
            //    if(item.EndsWith("esho"))
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
        }
    }
}
