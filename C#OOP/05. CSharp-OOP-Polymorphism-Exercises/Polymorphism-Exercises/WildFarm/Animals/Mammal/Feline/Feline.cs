using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammal.Feline
{
    public abstract class Feline : Mammal
    {
        public Feline(string name, double weight, string region,string breed) : base(name, weight, region)
        {
            this.Breed = breed;
        }

        public string  Breed { get; protected set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";

        }
    }
}
