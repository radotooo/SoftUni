using System;
using System.Collections.Generic;
using System.Text;


namespace WildFarm.Animals.Mammal
{
    public class Mouse : Mammal
    {
        private const double increase = 0.10;

        public Mouse(string name, double weight, string region) : base(name, weight, region)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name!= "Meat" && food.GetType().Name != "Fruit")
            {
                throw new ArgumentException($"{ this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            base.Eat(food);
            this.Weight += food.Quantity * increase;
        }

        public override string ProduceSound()
        {
            return $"Squeak";
        }
    }
}
