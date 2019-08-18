using System;

namespace Ferrari
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var car = new Ferrari(input);

            Console.WriteLine(car.ToString());
        }
    }
}
