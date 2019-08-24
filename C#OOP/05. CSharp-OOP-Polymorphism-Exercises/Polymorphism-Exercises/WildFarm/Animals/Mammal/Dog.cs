using System;
using System.Collections.Generic;
using System.Text;


namespace WildFarm.Animals.Mammal
{
   public class Dog : Mammal
    {
        private const double increase = 0.40;

        public Dog(string name, double weight, string region) : base(name, weight, region)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat")
            {
                throw new ArgumentException($"{ this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            base.Eat(food);
            this.Weight +=  food.Quantity* increase;
        }

        public override string ProduceSound()
        {
            return $"Woof!";
        }
    }
}
