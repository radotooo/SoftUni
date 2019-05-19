using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _6.__Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cars = Console.ReadLine().Split().ToList();
            List<string> servedCars = new List<string>();
            Stack<string> carsDone = new Stack<string>();

            var tobeServed = new Queue<string>();
            foreach (var item in cars)
            {
                tobeServed.Enqueue(item);
            }


            while (true)
            {
                //string[] command = Regex.Split(Console.ReadLine(), @"\W+");
                List<string> command = Console.ReadLine().Split(new char[] { ' ', '-' },StringSplitOptions.RemoveEmptyEntries).ToList();

                if(command[0]=="End")
                {
                    if (tobeServed.Count > 0)
                    {
                        Console.Write("Vehicles for service: ");
                        Console.Write(string.Join(", ", tobeServed));
                        Console.WriteLine();


                    }
                    Console.Write("Served vehicles: ");
                    Console.Write(string.Join(", ", carsDone));
                   
                    //return;
                    break;
                }
               else  if (command[0] == "Service")
                {
                    if (tobeServed.Count > 0)
                    {
                        string carServed = tobeServed.Dequeue();
                        carsDone.Push(carServed);
                        servedCars.Add(carServed);
                        Console.WriteLine($"Vehicle {carServed} got served.");
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command[0] == "CarInfo")
                {
                    string carChek = command[1];

                    if(servedCars.Contains(carChek))
                    {
                        Console.WriteLine("Served.");
                    }
                    else
                    {
                        Console.WriteLine("Still waiting for service.");
                    }


                }
                else if (command[0]=="History")
                {
                    //Console.WriteLine("Served venicles: ");
                    
                    Console.Write(string.Join(", ",carsDone));
                    Console.WriteLine();
                }




            }
        }
    }
}
