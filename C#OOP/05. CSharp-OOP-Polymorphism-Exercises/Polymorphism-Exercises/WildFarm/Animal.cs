using System;
using System.Collections.Generic;
using System.Text;



namespace WildFarm.Animals
{
    public abstract class Animal
    {
        public string Name { get; protected set; }
        public double  Weight { get; protected set; }
        public int FoodEaten { get; protected set; }
        
        public Animal(string name , double weight )
        {
            this.Name = name;
            this.Weight = weight;
        }

        public abstract string ProduceSound();

        public virtual void Eat(Food food)
        {
            this.FoodEaten += food.Quantity;
            
        }

    }
}
