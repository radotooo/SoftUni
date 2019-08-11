using System;
using System.Collections.Generic;

namespace _08.Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            Queue<string> bb = new Queue<string>();
            int counter = 0;


            while (true)
            {

                string input = Console.ReadLine();
                if(input == "end")
                {
                    break;
                }
                else if (input == "green")
                {
                    if(num>bb.Count)
                    {
                        num = bb.Count;
                    }
                    for (int i = 0; i < num; i++)
                    {
                        Console.WriteLine($"{bb.Dequeue()} passed!");
                        counter++;

                    }
                    continue;
                }
                
                bb.Enqueue(input);
               
                

            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
