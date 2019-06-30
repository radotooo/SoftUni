using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.Make = Console.ReadLine();
            //car.Model = Console.ReadLine();
            //car.Year = int.Parse(Console.ReadLine());
            //car.FuelConsumption = double.Parse(Console.ReadLine());
            //car.FuelQuantity = double.Parse(Console.ReadLine());
            //car.Drive(double.Parse(Console.ReadLine()));
            //Console.WriteLine(car.WhoAmI());
            //Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
            //Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
            //string make = Console.ReadLine();
            //string model = Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double rado = double.Parse(Console.ReadLine());
            //double rado2 = double.Parse(Console.ReadLine());




            //Car firstCar = new Car();
            //Car secondCar = new Car(make, model, year);
            //Car thirdCar = new Car(make, model, year, rado, rado2);

            List<Tire[]> tireList = new List<Tire[]>();
            List<Engine> engineList = new List<Engine>();
            List<Car> carList = new List<Car>();


            while (true)
            {
                string tireInput = Console.ReadLine();

                if (tireInput == "No more tires")
                {
                    break;
                }

                List<int> years = new List<int>();
                List<double> pressures = new List<double>();

                int count = 1;

                foreach (var item in tireInput.Split(" ").ToArray())
                {
                    if (count % 2 == 0)
                    {
                        pressures.Add(double.Parse(item));
                    }
                    else
                    {
                        years.Add(int.Parse(item));
                    }
                    count++;
                }
                count = 1;
                var tires = new Tire[4]
            {
                    new Tire(years[0],pressures[0]),
                    new Tire(years[1],pressures[1]),
                    new Tire(years[2],pressures[2]),
                    new Tire(years[3],pressures[3]),
            };
                tireList.Add(tires);
                years.Clear();
                pressures.Clear();
            }


            while (true)
            {
                string[] enginesInput = Console.ReadLine().Split().ToArray();

                if(enginesInput[0] == "Engines")
                {
                    break;
                }

                var engine = new Engine(int.Parse(enginesInput[0]), double.Parse(enginesInput[1]));
                engineList.Add(engine);

            }

            

            while (true)
            {
                string[] carss = Console.ReadLine().Split().ToArray();
                if(carss[0]=="Show")
                {
                    break;
                }


                var car = new Car(carss[0], carss[1], 
                    int.Parse(carss[2]), 
                    int.Parse(carss[3]), 
                    int.Parse(carss[4]), 
                    engineList[int.Parse(carss[5])], 
                    tireList[int.Parse(carss[6])]);

                car.Drive(20);

                carList.Add(car);
            }

            double tirepresureSum = 0;

            foreach (var item in carList.Where(x => x.Year >= 2017).Where(x => x.Engine.HorsePower > 330))
            {

                foreach (var presurr in item.Tire)
                {
                    tirepresureSum += presurr.Pressure;
                }
               if(tirepresureSum >9 && tirepresureSum<10)
                {
                    StringBuilder result = new StringBuilder();
                    result.AppendLine($"Make: {item.Make}");
                    result.AppendLine($"Model: {item.Model}");
                    result.AppendLine($"Year: {item.Year}");
                    result.AppendLine($"HorsePowers: {item.Engine.HorsePower}");
                    result.AppendLine($"FuelQuantity: {item.FuelQuantity}");
                    Console.WriteLine(result.ToString());
                    tirepresureSum = 0;
                }
            }




            //var engine = new Engine(560, 6300);

            //var car = new Car("Lamborgini", "Urus", 2010, 250, 9, engine, tires);







        }
    }
}
