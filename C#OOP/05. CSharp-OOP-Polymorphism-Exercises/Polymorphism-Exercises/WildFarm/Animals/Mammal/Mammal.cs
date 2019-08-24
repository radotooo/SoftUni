using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animals.Mammal
{
    public abstract class Mammal : Animal
    {
        public Mammal(string name, double weight , string region) : base(name, weight)
        {
            this.LivingRegion = region;

        }
        
        public string LivingRegion { get; protected set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";

        }
        //public override string ProduceSound()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
