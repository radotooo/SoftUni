using System;



namespace CarManufacturer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 1992;
            //car.FuelConsumption = 200;
            //car.FuelQuantity = 200;
            //car.Drive(2000);
            //Console.WriteLine(car.WhoAmI());
            //Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");

            string make = Console.ReadLine();
            string model = Console.ReadLine();
            int year = int.Parse(Console.ReadLine());
            double rado = double.Parse(Console.ReadLine());
            double rado2 = double.Parse(Console.ReadLine());




            Car firstCar = new Car();
            Car secondCar = new Car(make,model,year);
            Car thirdCar = new Car(make, model, year, rado,rado2);


        }
    }
}
