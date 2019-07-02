using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();

            for (int i = 0; i < numberCount; i++)
            {
                string[] cars = Console.ReadLine().Split();

                string carModel = cars[0];
                double fuelAmount = double.Parse(cars[1]);
                double amountOfKm = double.Parse(cars[2]);

                var currentCar = new Car(carModel, fuelAmount, amountOfKm);

                carList.Add(currentCar);
            }


            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "End")
                {
                    break;
                }

                string carModel = input[1];
                double amoutOfKm = double.Parse(input[2]);

                var currentCar = carList.FirstOrDefault(x => x.Model == carModel);
                currentCar.Drive(amoutOfKm);

            }

            foreach (var car in carList)
            {
                Console.WriteLine(car);
            }
        }
    }
}
