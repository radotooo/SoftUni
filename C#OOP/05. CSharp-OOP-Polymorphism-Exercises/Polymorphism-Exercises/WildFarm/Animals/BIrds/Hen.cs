using System;
using System.Collections.Generic;
using System.Text;


namespace WildFarm.Animals.BIrds
{
    public class Hen : Bird
    {
        private const double increase = 0.35;
        public Hen(string name, double weight, double wingSise) : base(name, weight, wingSise)
        {
        }

        public override void Eat(Food food)
        {
            
            this.FoodEaten += food.Quantity;
            this.Weight += food.Quantity * increase;

        }

        public override string ProduceSound()
        {
            return $"Cluck";
        }
    }
}
