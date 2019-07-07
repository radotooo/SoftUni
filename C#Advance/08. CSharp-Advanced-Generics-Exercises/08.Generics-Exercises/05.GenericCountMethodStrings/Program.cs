using System;

namespace _05.GenericCountMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var boxList = new Box<double>();

           
            

            for (int i = 0; i < num; i++)
            {
                var input = double.Parse(Console.ReadLine());
                boxList.Add(input);
            }

            double element = double.Parse(Console.ReadLine());
           boxList.MyMethod(boxList, element);

           
        }
    }
}
