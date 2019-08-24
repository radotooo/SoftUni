using System;
using System.Collections.Generic;
using System.Text;


namespace WildFarm.Animals.BIrds
{
   public  class Owl : Bird
    {
        private const double increase = 0.25;

        public Owl(string name, double weight, double wingSise) : base(name, weight, wingSise)
        {
        }

        public override void Eat(Food food)
        {
            if(food.GetType().Name != "Meat")
            {
                throw new ArgumentException($"{ this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            base.Eat(food);
            this.Weight += food.Quantity * increase;

        }

        public override string ProduceSound()
        {
            return $"Hoot Hoot";
        }
    }
}
