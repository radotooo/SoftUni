using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : SpecialisedSoldier ,IEngineer
    {
        public Engineer(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            this.RepairList = new List<IRepair>();
        }

        public List<IRepair> RepairList { get;  set; }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            sb.AppendLine($"Corps: {this.Corps}");
            sb.AppendLine("Repairs:");
            foreach (var item in RepairList)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString().TrimEnd();

        }
        public void Add(Repair repair)
        {
            this.RepairList.Add(repair);
            
        }

    }
}
