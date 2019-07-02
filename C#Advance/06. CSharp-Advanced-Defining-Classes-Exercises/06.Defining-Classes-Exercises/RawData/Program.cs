using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Car> myCars = new List<Car>();
            //each of the next N lines, you will receive 
            //    an information about each car in the format:
            //"{model} {engineSpeed} {enginePower} {cargoWeight} " +
            //                "{cargoType} {tire1Pressure} " +
            //                "{tire1Age} {tire2Pressure} {tire2Age} " +
            //                "{tire3Pressure} {tire3Age} {tire4Pressure}" +
            //                " {tire4Age}"
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();

                var currentCar = new Car();

                currentCar.Model = input[0];

                var currentEngine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                currentCar.Engine = currentEngine;

                var currentCargp = new Cargo( input[4] ,int.Parse(input[3]) );
                currentCar.Cargo = currentCargp;

                Tire currentTire = new Tire(double.Parse(input[5]), int.Parse(input[6]), double.Parse(input[7]), int.Parse(input[8]),
                    double.Parse(input[9]), int.Parse(input[10]), double.Parse(input[11]),int.Parse(input[12]));
                currentCar.Tire = currentTire;


                //currentCar.TirePressure = currentTirePressure;
                //Tire currentTireAge = new Tire();
                //currentCar.TireAge = currentTirePressure;


                myCars.Add(currentCar);




            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var item in myCars.Where(x => x.Cargo.CargoType == "fragile"))
                {

                    foreach (var item2 in item.Tire.TirePressure)
                    {
                        if (item2 < 1)
                        {
                            Console.WriteLine(item.Model);
                            break;
                        }
                    }

                }
            }
            else
            {
                //"flamable" - print all of the cars, whose cargo is "flamable" and have engine power > 250
                foreach (var item in myCars.Where(x => x.Cargo.CargoType == "flamable").Where(x=>x.Engine.EnginePower>250))
                {
                    Console.WriteLine(item.Model);
                }
            }


        }
    }
}
