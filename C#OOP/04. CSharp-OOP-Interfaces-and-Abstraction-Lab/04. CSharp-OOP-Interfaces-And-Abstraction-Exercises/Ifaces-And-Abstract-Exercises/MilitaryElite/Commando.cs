using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            MissionList = new List<Imission>();
        }

        public List<Imission> MissionList { get; set; }
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine("Missions:");
            foreach (var item in MissionList)
            {
                if (item.State == "inProgress")
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString().TrimEnd();

        }
        public void Add(Mission mission)
        {
            this.MissionList.Add(mission);

        }
    }
}
