using System;
using System.Collections.Generic;
using System.Text;

namespace Pokemon
{
    public class Pokemon
    {
        private string name;
        public int health;
        private string element;

        public Pokemon(string name , int healt,string element)
        {
            Name = name;
            Health = healt;
            Element = element;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Element
        {
            get { return element; }
            set { element = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }


    }
}
