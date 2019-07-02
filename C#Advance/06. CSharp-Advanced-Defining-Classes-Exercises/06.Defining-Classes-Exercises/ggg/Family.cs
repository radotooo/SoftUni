using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ggg
{
    public class Family
    {


        private List<Person> familyMembers;

        public Family()
        {
            this.familyMembers = new List<Person>();
        }



        public List<Person> FamilyMembers
        {
            get { return this.familyMembers; }
            set { this.familyMembers = value; }
        }

        public void AddMembers(Person member)
        {
            this.familyMembers.Add(member);
        }

        public Person GetOldesMember()
        {
            return familyMembers.OrderByDescending(x => x.Age).First();
        }
    }
}
