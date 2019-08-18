using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral :Soldier, ILieutenantGeneral
    {


        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.PrivateList = new List<IPrivate>();

        }
        public List<IPrivate> PrivateList { get; private set; }

        public decimal Salary { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Id { get; private set; }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            sb.AppendLine("Privates:");
            foreach (var item in PrivateList)
            {
                sb.AppendLine($"  Name: {item.FirstName} {item.LastName} Id: {item.Id} Salary: {item.Salary:F2}");
            }
            return sb.ToString().TrimEnd();

        }
        public void Add(Private privatee)
        {
            PrivateList.Add(privatee);
            
        }
    }

}
