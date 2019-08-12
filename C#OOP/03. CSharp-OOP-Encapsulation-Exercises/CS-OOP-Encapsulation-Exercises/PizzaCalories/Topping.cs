using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private string toppingValue;
        private int weight;


        public Topping(string name , int weight)
        {
            this.ToppingValue = name;
            this.Weight = weight;
        }

        public int Weight
        {
            get
            {
                return weight;
            }
            protected set
            {
                if(value < 1 || value >  50)
                {
                    throw new ArgumentException($"{this.ToppingValue} weight should be in the range[1..50].");
                }
                weight = value;
            }
        }

       

        public string ToppingValue
        {
            get
            {
                return toppingValue;
            }
            protected set
            {
                if(value.ToLower() == "meat" || value.ToLower() == "veggies" 
                    || value.ToLower() == "cheese" || value.ToLower() == "sauce")
                {
                    toppingValue = value;

                }
                else
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
            }
        }
        public double CalculateCalories()
        {
            double toppingCal = 0;
            
            switch (this.ToppingValue.ToLower())
            {
                case "meat": toppingCal = 1.2; break;
                case "veggies": toppingCal = 0.8; break;
                case "cheese": toppingCal = 1.1; break;
                case "sauce": toppingCal = 0.9; break;


                default:
                    break;
            }
            

            return (this.Weight * 2) * toppingCal;


        }

    }
}
