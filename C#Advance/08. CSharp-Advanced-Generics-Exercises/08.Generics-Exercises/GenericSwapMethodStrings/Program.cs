using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var boxList = new List<Box<int>>();
            for (int i = 0; i < num; i++)
            {
                var data = int.Parse(Console.ReadLine());
                var currentBox = new Box<int>(data);
                boxList.Add(currentBox);
               
            }

            int[] swapCommand = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int num1 = swapCommand[0];
            int num2 = swapCommand[1];

            Box<string>.MyMethod(boxList, num1, num2);
            foreach (var item in boxList)
            {
                Console.WriteLine($"{item.data.GetType()}: {item.data}");
            }

        }

    }

    
}
