using System;
using System.Collections.Generic;
using System.Text;


namespace WildFarm.Animals.Mammal.Feline
{
    public class Cat :Feline
    {
        private const double increase = 0.30;

        public Cat(string name, double weight, string region, string breed) : base(name, weight, region, breed)
        {
        }

        public override void Eat(Food food)
        {
            if (food.GetType().Name != "Meat" && food.GetType().Name != "Vegetable")
            {
                throw new ArgumentException($"{ this.GetType().Name} does not eat {food.GetType().Name}!");
            }
            base.Eat(food);
            this.Weight += food.Quantity * increase;
        }

        public override string ProduceSound()
        {
            return $"Meow";
        }
    }
}
