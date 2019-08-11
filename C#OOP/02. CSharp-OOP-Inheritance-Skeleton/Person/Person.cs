

using System;
using System.Text;

namespace Person
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }



        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }



       


        

        public  override  string ToString()
        {
            StringBuilder sbt = new StringBuilder();
            sbt.Append($"Name: {this.Name}, Age: {this.Age}");
            return sbt.ToString();
        }
    }
}
