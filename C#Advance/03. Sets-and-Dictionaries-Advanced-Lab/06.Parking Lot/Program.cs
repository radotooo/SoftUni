using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _06.Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var parkingLot = new HashSet<string>();

            while (input!="END")
            {
                var cars = Regex.Split(input, ", ");

                if(cars[0]=="IN")
                {
                    parkingLot.Add(cars[1]);
                }
                else
                {
                    parkingLot.Remove(cars[1]);
                }
                input = Console.ReadLine();
            }

            if (parkingLot.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");

            }
            else
            {
                foreach (var cars in parkingLot)
                {
                    Console.WriteLine(cars);
                }
            }

        }
    }
}
