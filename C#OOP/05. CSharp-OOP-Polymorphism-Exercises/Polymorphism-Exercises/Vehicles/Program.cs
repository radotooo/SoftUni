using System;

namespace Vehicles
{
   public  class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();


            var car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]),int.Parse(carInfo[3]));
            var truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), int.Parse(truckInfo[3]));
            var bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), int.Parse(busInfo[3]));


            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string[] input = Console.ReadLine().Split();
                string operation = input[0];
                string venichleType = input[1];
                double num = double.Parse(input[2]);

                ChekVenichke(venichleType, operation, num, car, truck,bus);

            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);



        }
        public static void ChekVenichke(string veniChletype,string operation, double num, Car car , Truck truck,Bus bus)
        {
            try
            {
                if (veniChletype == "Car")
                {
                    if (operation == "Drive")
                    {
                        Console.WriteLine(car.Drive(num));
                    }
                    else
                    {
                        car.Refuel(num);
                    }
                }
                else if (veniChletype == "Truck")
                {
                    if (operation == "Drive")
                    {
                        Console.WriteLine(truck.Drive(num));

                    }
                    else
                    {
                        truck.Refuel(num);
                    }
                }
                else if (veniChletype == "Bus")
                {
                    if (operation == "Drive")
                    {
                        Console.WriteLine(bus.Drive(num));

                    }
                    else if (operation == "DriveEmpty")
                    {
                        Console.WriteLine(bus.DriveEmpty(num));
                    }
                    else
                    {
                        bus.Refuel(num);
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           

        }

        //public static void ChekOperation(string operation)
        //{

        //    if(operation=="Drive")
        //    {

        //    }
        //    else
        //    {

        //    }
        //}
    }
}
