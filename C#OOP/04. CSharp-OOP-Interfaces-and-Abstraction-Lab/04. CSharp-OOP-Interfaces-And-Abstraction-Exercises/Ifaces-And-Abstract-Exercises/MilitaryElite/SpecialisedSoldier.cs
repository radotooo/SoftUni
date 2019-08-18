using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class SpecialisedSoldier : ISpecialSoldier
    {
        private string corps;

        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary,string corps)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Corps = corps;

        }

        public string Corps
        {
            get
            {
                return this.corps;
            }
            set
            {
                if(value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException("GG");
                }
                this.corps = value;
            }
        }

        public decimal Salary { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public int Id { get; private set; }
    }
}
