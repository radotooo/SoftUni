using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator 
{
    public class Player 
    {
        private string name;
        private Stat playerStat;

        public Player(string name , Stat stat)
        {
            this.Name = name;
            this.PlayerStat = stat;
        }

        public Stat PlayerStat
        {
            get { return playerStat; }
            private set { playerStat = value; }
        }



        public string Name
        {
            get { return name; }
            private set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public double OverallSkill => this.PlayerStat.FindOverageStats();
    }
}
