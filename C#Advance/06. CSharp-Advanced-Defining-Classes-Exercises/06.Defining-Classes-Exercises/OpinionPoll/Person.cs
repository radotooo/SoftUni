using System;
using System.Collections.Generic;
using System.Text;

namespace _04.Opinion_Poll
{
   public class Person
    {
        private string _name;
        private int _age;

        public Person()
        {
            this._name = "No name";
            this._age = 1;
        }

        public Person(int age)
            :this()
        {
            this._age = age;
        }

        public Person(string name,int age)
            :this(age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                //if (value.Length < 2)
                //{
                //    throw new ArgumentException("blabalbal");
                //}
                _name = value;
            }
        }


        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

    }
}
