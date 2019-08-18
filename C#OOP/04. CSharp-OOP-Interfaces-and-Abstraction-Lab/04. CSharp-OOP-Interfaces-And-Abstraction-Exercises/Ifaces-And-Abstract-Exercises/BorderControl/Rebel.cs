using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Rebel : IBurthday,IBuyer
    {
        public string Birthday { get; private set; }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int Food { get; set; }
        public string Group { get; set; }

        public Rebel(string name , int age , string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
