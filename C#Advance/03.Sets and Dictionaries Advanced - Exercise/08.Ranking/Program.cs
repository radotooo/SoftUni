using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        

        
        static void Main(string[] args)
        {

            Dictionary<string, string> contest = new Dictionary<string, string>();
            var result = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if(input[0] == "end of contests")
                {
                    break;
                }

                string contestt = input[0];
                string password = input[1];

                contest[contestt] = password;

            }

            
            while (true)
            {



                string[] input = Console.ReadLine().Split(new string[] { "=>" }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if(input[0]=="end of submissions")
                {
                    break;
                }
                string contestt = input[0];
                string password = input[1];
                string username = input[2];
                int point = int.Parse(input[3]);

                if(contest.ContainsKey(contestt) && contest[contestt] == password)
                {

                    if(!result.ContainsKey(username))
                    {
                        result[username] = new Dictionary<string, int>();
                        result[username][contestt] = point;

                    }
                   if(!result[username].ContainsKey(contestt))
                    {
                       
                            result[username][contestt] = point;
                        
                    }
                   else
                    {
                        if (result[username][contestt] < point)
                        {
                            result[username][contestt] = point;
                        }
                    }
                 


                }

                
            }


            int bestValue = 0;

            
            foreach (var bestCandidate in result.OrderByDescending(x => x.Value.Values.Max()))
            {
                foreach (var points in bestCandidate.Value)
                {
                    bestValue += points.Value;
                }
                Console.WriteLine($"Best candidate is {bestCandidate.Key} with total {bestValue} points.");
                break;
            }


            foreach (var person in result.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{person.Key} ");
                foreach (var contestAndPoints in person.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"#  {contestAndPoints.Key} -> {contestAndPoints.Value}");
                }
            }

        }
    }
}
