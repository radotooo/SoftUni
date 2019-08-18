using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Private : Soldier, IPrivate
    {

        public Private(int id , string firstName , string lastName , decimal salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;

        }

        public decimal Salary { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Id { get; private set; }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            
            sb.Append($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:F2}");
            return sb.ToString();

        }


    }
}
