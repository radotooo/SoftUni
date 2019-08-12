using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {

        private string flourType;

        private string bakingTechnique;

        private int weight;

        public Dough(string flourType, string backing, int weight)
        {
            this.BakingTechnique = backing;
            this.FlourType = flourType;
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
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");

                }
                weight = value;
            }
        }


        public string BakingTechnique
        {
            get
            {
                return bakingTechnique;
            }
            protected set
            {
                if (value.ToLower() == "crispy" || value.ToLower() == "chewy" || value.ToLower() == "homemade")
                {

                    bakingTechnique = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");

                }
            }

        }
        public string FlourType
        {
            get
            {
                return flourType;
            }
           protected set
            {
                if (value.ToLower() == "white" || value.ToLower() == "wholegrain")
                {
                    flourType = value;
                }
                else
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

            }
        }
        public double CalculateCalories()
        {
            double fType = 0;
            double tType = 0;
            switch (this.FlourType.ToLower())
            {
                case "white": fType = 1.5; break;
                case "wholegrain": fType = 1.0; break;
                default:
                    break;
            }
            switch (this.BakingTechnique.ToLower())
            {
                case "crispy": tType = 0.9; break;
                case "chewy": tType = 1.1; break;
                case "homemade": tType = 1.0; break;
                default:
                    break;
            }

            return (this.Weight * 2) * tType * fType;


        }
    }
}
