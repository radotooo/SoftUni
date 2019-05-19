using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());
            List<int> quantutyOfFood = Console.ReadLine().Split().Select(int.Parse).ToList();
            Queue<int> orders = new Queue<int>(quantutyOfFood);
            int biggerInt = orders.Max();
            for (int i = 0; i < quantutyOfFood.Count; i++)
            {
                int currentOrder = orders.Peek();
                if(currentOrder<=quantity)
                {
                    quantity -= currentOrder;
                    orders.Dequeue();
                }
                else
                {
                    Console.WriteLine($"{biggerInt}");

                    Console.Write("Orders left: ");
                    while (orders.Count>0)
                    {
                        Console.Write(orders.Dequeue()+" ");
                    }
                    return;
                }
                
            }
            Console.WriteLine($"{biggerInt}");
            Console.WriteLine($"Orders complete");

        }
    }
}
