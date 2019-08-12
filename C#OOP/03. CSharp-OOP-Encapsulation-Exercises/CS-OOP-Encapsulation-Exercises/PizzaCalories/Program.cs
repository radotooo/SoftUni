using System;

namespace PizzaCalories
{
   public  class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaName = Console.ReadLine().Split();
                var pizza = new PIzza(pizzaName[1]);
                string[] doughInput = Console.ReadLine().Split();
                pizza.Dough = new Dough(doughInput[1], doughInput[2], int.Parse(doughInput[3]));

                while (true)
                {
                    string[] topping = Console.ReadLine().Split();
                    if (topping[0] == "END")
                    {
                        break;
                    }
                    pizza.Add(new Topping(topping[1], int.Parse(topping[2])));

                }
                Console.WriteLine(pizza);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           

            //var dough = new Dough("White", "Chewy", 100);
            //var doughhh = new Topping("Meat" ,44);
            //var piza = new PIzza("PEsho");

            ////while (true)
            ////{
            //int count = 0;
            //while (count < 12)
            //{
            //    piza.Add(new Topping("Meat", 44));
            //    count++;

            //}

            ////}
            //Console.WriteLine(dough.CalculateCalories());
            //Console.WriteLine(doughhh.CalculateCalories());



        }
    }
}
