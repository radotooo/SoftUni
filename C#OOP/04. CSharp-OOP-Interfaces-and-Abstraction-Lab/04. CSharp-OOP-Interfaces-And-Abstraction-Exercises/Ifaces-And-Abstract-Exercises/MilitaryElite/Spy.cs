using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int code) 
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CodeNumber = code;
        }

        public int CodeNumber { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Id { get; private set; }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id}");
            sb.Append($"Code Number: {this.CodeNumber}");
            return sb.ToString();

        }
    }
}
