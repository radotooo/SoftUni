using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Stat
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stat(int endurance , int sprint , int dribble , int passing , int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }

        public int Shooting
        {
            get { return shooting; }

            private set
            {
                this.ValidateInput(value,"Shooting");
                shooting = value;
            }
        }



        public int Passing
        {
            get { return passing; }
            private set
            {
                this.ValidateInput(value,"Passing");
                passing = value;
            }
        }


        public int Dribble
        {
            get { return dribble; }
            private set
            {
                this.ValidateInput(value,"Dribble");
                dribble = value;
            }
        }


        public int Sprint
        {
            get { return sprint; }
            private set
            {
                this.ValidateInput(value,"Sprint");
                sprint = value;
            }
        }



        public int Endurance
        {
            get { return endurance; }
            private set
            {
                this.ValidateInput(value,"Endurance");
                endurance = value;
            }
        }

        private void ValidateInput(int value , string name )
        {
            if(value < 0 || value > 100)
            {
                throw new ArgumentException($"{name} should be between 0 and 100.");
            }
            
        }

        public double FindOverageStats()
        {
            double result = ((double)this.Passing + (double)this.Endurance + (double)this.Sprint + (double)this.Dribble + (double)this.Shooting) / 5.0;
            
            return result;
            
        }

    }
}
