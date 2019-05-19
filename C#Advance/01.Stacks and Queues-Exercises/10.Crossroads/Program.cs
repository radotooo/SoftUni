using System;
using System.Collections.Generic;

namespace _10.Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightTine = int.Parse(Console.ReadLine());
            int lightCycle = int.Parse(Console.ReadLine());
            int currentGreenTime = greenLightTine;
            int totalTime = greenLightTine + lightCycle;
            int count = 0;
            int currentTime = 0;
            int proba = 0;
            
            Queue<string> cars = new Queue<string>();
            List<char> cuurrentCar = new List<char>();



            while (true)
            {
                string input = Console.ReadLine();
                if(input=="green")
                {
                   string cardd = "";
                    while (true)
                    {
                        if (cars.Count == 0)
                        {
                            
                            break;
                        }
                        string currentCar = cars.Dequeue();

                        cardd = currentCar;

                        if (currentCar.Length < greenLightTine)
                        {
                            greenLightTine = greenLightTine - currentCar.Length;
                            count++;
                            continue;
                    }
                        else if (currentCar.Length==greenLightTine)
                        {
                            count++;
                            break;

                        }
                        else if (currentCar.Length > greenLightTine)
                        {
                            if (currentCar.Length <= greenLightTine + lightCycle)
                            {


                                count++;
                                break;
                            }
                            //else
                            //{
                            //    Console.WriteLine("A crash happened!");
                            //    Console.WriteLine($"{cardd} was hit at {cuurrentCar[currentCar.Length -( greenLightTine + lightCycle)]}.");
                            //    return;
                                
                            //}

                        }
                        {
                            foreach (var item in currentCar)
                            {
                                cuurrentCar.Add(item);
                            }
                            currentTime = greenLightTine + lightCycle;
                            break;
                        }
                    }
                    
                    //cuurrentCar.Reverse();
                    for (int i = 0; i < currentTime; i++)
                    {
                        if(cuurrentCar.Count==0)
                        {
                            count++;
                            break;
                        }
                        cuurrentCar.RemoveAt(0);
                    }
                    if(cuurrentCar.Count>0)
                    {
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{cardd} was hit at {cuurrentCar[0]}.");
                        return;
                    }
                    greenLightTine = currentGreenTime;

                }
                else if (input=="END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{count} total cars passed the crossroads.");
                    return;
                }
                else
                {
                    cars.Enqueue(input);
                }

            }

        }
    }
}
