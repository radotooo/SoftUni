using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int engineNum = int.Parse(Console.ReadLine());

            List<Car> carList = new List<Car>();
            List<Engine> engineList = new List<Engine>();

            for (int i = 0; i < engineNum; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int power = int.Parse(input[1]);
                int displacement = 0;
                string efficiency = "n/a";
                if (input.Length == 3)
                {
                    bool result = int.TryParse(input[2], out displacement);
                    if (!result)
                    {
                        efficiency = input[2];
                    }
                    
                }
                if(input.Length==4)
                {
                    displacement = int.Parse(input[2]);
                    efficiency = input[3];
                }
                    

                    var currentEngine = new Engine(model, power, displacement,efficiency);
                    engineList.Add(currentEngine);

                


            }



            int carsNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsNum; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string engine = input[1];
                int weight = 0;
                string color = "n/a";
                //bool result = true;
                //if (input.Length >= 3)
                //{

                //    result = int.TryParse(input[2], out weight);

                //}
                //if (!result || input.Length == 4)
                //{
                //    color = input[3];
                //}
                if (input.Length == 3)
                {
                    bool result = int.TryParse(input[2], out weight);
                    if (!result)
                    {
                        color = input[2];
                    }

                }
                if (input.Length == 4)
                {
                    weight = int.Parse(input[2]);
                   color = input[3];
                }
                var currentEngine = engineList.Where(x => x.Model == engine).First();

                var currentCar = new Car()
                {
                    Model = model,
                    Engine = currentEngine,
                    Weight = weight,
                    Color = color
                };

                carList.Add(currentCar);
            }


            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }


        }
    }
}
