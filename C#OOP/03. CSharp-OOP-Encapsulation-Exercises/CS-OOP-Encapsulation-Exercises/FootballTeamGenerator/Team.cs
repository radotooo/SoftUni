using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> teamPlayers;


        public Team(string name)
        {
            this.Name = name;
            teamPlayers = new List<Player>();

        }

        //public List<Player> MyProperty
        //{
        //    get { return teamPlayers; }
        //    set { teamPlayers = value; }
        //}
        public int Rating
        {
            get
            {
                if(this.teamPlayers.Count == 0)
                {
                    return 0;
                }

               return  (int)Math.Round(this.teamPlayers.Average(p => p.OverallSkill));

            }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public void Add(Player player)
        {

            teamPlayers.Add(player);
        }

        public void Remove(string name)
        {
            //bool succes = teamPlayers.Any(x => x.Name == name);
            if(!teamPlayers.Any(x => x.Name == name))
            {
                throw new ArgumentException($"Player {name} is not in {this.Name} team.");
            }
            var currentPlyaer = teamPlayers.FirstOrDefault(x => x.Name == name);
            teamPlayers.Remove(currentPlyaer);
        }

        //public double OverageStats()
        //{

        //    double result = 0;
        //    if(teamPlayers.Count == 0)
        //    {
        //        return 0;
        //    }
        //    foreach (var item in teamPlayers)
        //    {
        //        result += item.PlayerStat.FindOverageStats();
        //    }
        //     result /= teamPlayers.Count;
            
        //    return  Math.Round(result);
            
        //}

        public void ChekPlayerExist(string name)
        {

            if(!this.teamPlayers.Any(x=>x.Name == name))
            {
                throw new ArgumentException($"Player {name} is not in {this.Name} team.");
            }
        }
    }
}
