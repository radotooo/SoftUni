using System;
using System.Collections.Generic;
using System.Linq;

namespace _12_Cups_And_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cupsCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] cfilledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> bottle = new Stack<int>(cfilledBottles);
            Queue<int> cups = new Queue<int>(cupsCapacity);

            int wasteDWater = 0;

            int currentCup = 0;

            while (bottle.Count >0 && cups.Count>0)
            {

                int currentBottle = bottle.Pop();
                if (currentCup <= 0)
                {
                    currentCup = cups.Peek();
                }

                if (currentBottle>=currentCup)
                {
                    wasteDWater += (currentBottle - currentCup);
                    cups.Dequeue();
                    currentCup = 0;

                }
                else if (currentBottle<currentCup)
                {
                    currentCup -= currentBottle;
                    if(currentCup<=0)
                    {
                        cups.Dequeue();
                        currentCup = 0;
                        continue;
                    }
                }

            }
            if (cups.Count>0)
            {
                Console.WriteLine("Cups: {0}",string.Join(" ",cups));
                Console.WriteLine($"Wasted litters of water: {wasteDWater}");
            }
            else
            {
                Console.WriteLine("Bottles: {0}",string.Join(" ", bottle));
                Console.WriteLine($"Wasted litters of water: {wasteDWater}");
            }
        }
    }
}
