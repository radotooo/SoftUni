
using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string, int[]> result = new Dictionary<string, int[]>();

            Dictionary<string, List<string>> vllogerStats = new Dictionary<string, List<string>>();
            Dictionary<string, HashSet<string>> g = new Dictionary<string, HashSet<string>>();



            while (true)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input[0] == "Statistics")
                {
                    break;
                }

                if (input[1] == "joined")
                {
                    string vlogger = input[0];

                    if (!result.ContainsKey(vlogger))
                    {

                        result[vlogger] = new int[2];
                    }
                    else
                    {
                        continue;
                    }

                    // 0- following - селдва
                    // 1 - followed - следватГо

                }
                else if (input[1] == "followed")
                {

                    string vlogger = input[0];
                    string secondVlogger = input[2];

                    if (secondVlogger == vlogger)
                    {
                        continue;
                    }
                    else if (!result.ContainsKey(vlogger) || !result.ContainsKey(secondVlogger))
                    {
                        continue;
                    }

                    if (!g.ContainsKey(secondVlogger))
                    {
                        g[secondVlogger] = new HashSet<string>();
                        g[secondVlogger].Add(vlogger);
                    }
                    else
                    {
                        g[secondVlogger].Add(vlogger);

                    }



                    if (!vllogerStats.ContainsKey(vlogger))
                    {
                        vllogerStats[vlogger] = new List<string>();
                        vllogerStats[vlogger].Add(secondVlogger);
                        result[vlogger][0]++;
                        result[secondVlogger][1]++;

                    }
                    else
                    {
                        if (vllogerStats[vlogger].Contains(secondVlogger))
                        {
                            continue;
                        }
                        else
                        {
                            vllogerStats[vlogger].Add(secondVlogger);
                            result[vlogger][0]++;
                            result[secondVlogger][1]++;

                        }
                    }
                }





            }

            Console.WriteLine($"The V-Logger has a total of {result.Count} vloggers in its logs.");

            int count = 1;

            
            
            // 0- following - селдва
            // 1 - followed - следватГо

            foreach (var item in result.OrderByDescending(x => x.Value[1]).ThenBy(x => x.Value[0]))
            {

                Console.WriteLine($"{count}. {item.Key} : {item.Value[1]} followers, {item.Value[0]} following");
                if (count == 1)
                {
                    foreach (var item2 in g)
                    {
                        if (item2.Key == item.Key)
                        {
                            foreach (var item3 in item2.Value.OrderBy(x => x))
                            {
                                Console.WriteLine($"*  {item3}");
                            }
                        }

                    }
                }

                count++;
            }
            

        }
    }
}
