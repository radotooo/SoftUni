using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            //string[] teamName = Console.ReadLine().Split(";").ToArray();
            /*ar team = new Team(teamName[1]);*/
            List<Team> teamList = new List<Team>();


            while (true)
            {
                string[] input = Console.ReadLine().Split(";");

                if (input[0] == "END")
                {
                    break;
                }
                else if (input[0] == "Team")
                {
                    try
                    {
                        string teamName = input[1];
                        var team = new Team(teamName);
                        teamList.Add(team);
                    }
                    catch (Exception ex )
                    {
                        Console.WriteLine( ex.Message);
                        continue;
                        
                    }
                   
                }
                else if (input[0] == "Add")
                {
                 
                    if (!teamList.Any(x => x.Name == input[1]))
                    {
                        Console.WriteLine($"Team {input[1]} does not exist.");
                        continue;
                    }
                    var currentTeam = teamList.FirstOrDefault(x => x.Name == input[1]);
                    
                    try
                    {
                        var stat = new Stat(int.Parse(input[3]), int.Parse(input[4]), int.Parse(input[5]), int.Parse(input[6]), int.Parse(input[7]));
                        var player = new Player(input[2], stat);
                        currentTeam.Add(player);
                        
                    }
                    catch (Exception ex )
                    {

                        Console.WriteLine(ex.Message);
                        continue;
                    }
                   

                }
                else if ( input[0] == "Remove")
                {
                    if (!teamList.Any(x => x.Name == input[1]))
                    {
                        Console.WriteLine($"Team {input[1]} does not exist.");
                        continue;
                    }
                    try
                    {
                        var currentTeam = teamList.FirstOrDefault(x => x.Name == input[1]);
                        currentTeam.Remove(input[2]);
                        
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex.Message);
                        continue;
                    }
                   



                }
                else if (input[0] == "Rating")
                {
                    if (!teamList.Any(x => x.Name == input[1]))
                    {
                        Console.WriteLine($"Team {input[1]} does not exist.");
                        continue;
                    }
                    var currentTeam = teamList.FirstOrDefault(x => x.Name == input[1]);
                    Console.WriteLine($"{input[1]} - {currentTeam.Rating}"); 
                }
            }

            //var stat = new Stat(5, 4, 3, 2, 1);

            //var data = new List<Team>();

            //var team = new Team("Arsenal");
            ////var stats = new Stat(75, 85, 84, 92, 67);
            ////team.Add(new Player("Kieran_Gibbs", new Stat(75, 85, 84, 92, 67)));
            ////team.Add(new Player("Aaron_Ramsey", new Stat(95, 82, 82, 89, 68)));
            ////Console.WriteLine(stats.FindOverageStats());

            ////Console.WriteLine(team);
            //Console.WriteLine(team.OverageStats());

            //Console.WriteLine(stat.FindOverageStats());
        }
    }
}
