using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class PIzza
    {

        private string name;
        private Dough dough;
        private List<Topping> toppingsList;
        
        
       


        

        public PIzza(string name)
        {


            this.Name = name;
            toppingsList = new List<Topping>();
        }



        public int NumberOFToppings
        {
            get { return toppingsList.Count; }
            
        }

        public double TotalCalories()
        {

            double result = 0;
            result += this.Dough.CalculateCalories();
            foreach (var item in toppingsList)
            {
                result += item.CalculateCalories();
            }
            return result;
        }

       

       

        public Dough Dough
        {
             get { return dough; }
             set { dough = value; }
        }



        public string Name
        {
            get { return name; }

           private set
            {
                if(string.IsNullOrWhiteSpace(value)||string.IsNullOrEmpty(value) || value.Length < 1 || value.Length>15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }

        public void Add(Topping topping)
        {
            if (toppingsList.Count >= 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }
            toppingsList.Add(topping);


        }

        public override string ToString()
        {
            return $"{this.Name} - {this.TotalCalories():F2} Calories.";
        }
    }
}
