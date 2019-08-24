using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {
        public string  Name { get; protected set; }
        public string FavoriteFood { get; protected set; }

        public Animal(string name , string food)
        {
            this.Name = name;
            this.FavoriteFood = food;
        }

        public virtual string ExplainSelf()
        {

            return $"I am {this.Name} and my favorite food is {this.FavoriteFood}";
        }
    }
}
