using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Mission : Imission
    {
        public string CodeName { get; set; }
        
        private string state;
        public string State
        {
            get
            {
                return this.state;
            }
            private set
            {
                if (value != "inProgress" && value != "finished")
                {
                    throw new ArgumentException();
                }

                this.state = value;
            }
        }

       

        public Mission(string codeName , string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public void CompleteMission(Mission mission)
        {
            mission.State = "Finished";
        }
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();

            sb.Append($" Code Name: {this.CodeName} State: {this.State}");

            return sb.ToString().TrimEnd();

        }
    }
}
